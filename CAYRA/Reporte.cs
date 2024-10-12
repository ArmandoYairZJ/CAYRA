using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.IO;
using RDN;


namespace CAYRA
{
    public partial class Reporte : Form
    {
        private SQLServerClass sqlclass;

        public Reporte()
        {
            InitializeComponent();
            this.sqlclass = new SQLServerClass();

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
            try
            {
                sqlclass.SiHayConexion(inicio.UsuarioSql, inicio.Contrasena);
                cargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Existio algun error {ex.Message}");
            }

        }

        //Cargar datos al dgv 
        public void cargarDatos()
        {
            try
            {
                DataTable registros = sqlclass.Datos(inicio.UsuarioSql, inicio.Contrasena);

                DGVReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DGVReporte.DataSource = registros;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botones para generar reportes
        private void btnReporteFecha_Click(object sender, EventArgs e)
        {

            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                DateTime IN = DTPinicio.Value.Date;
                DateTime FN = DTPfin.Value.Date;

                if (!sqlclass.FechaExiste(inicio.UsuarioSql, inicio.Contrasena, IN, FN))
                {

                    MessageBox.Show(
                      "Una o ambas fechas no existen en la base de datos. Por favor, verifica las fechas e inténtalo de nuevo.",
                       "Advertencia",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );


                    return;
                }

                DataTable RP = sqlclass.RP(inicio.UsuarioSql, inicio.Contrasena, IN, FN);

                string FCA = DateTime.Now.ToString("yyyyMMdd");
                string baseFilePath = $@"D:\Todos los semestres de la uni\Universidad9\Gestion\Reportes\resultados_{FCA}";
                string filePath = baseFilePath + ".xlsx";
                int fileIndex = 1;

                while (File.Exists(filePath))
                {
                    filePath = $"{baseFilePath}_{fileIndex}.xlsx";
                    fileIndex++;
                }

                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Resultados");

                    for (int i = 0; i < RP.Columns.Count; i++)
                    {
                        var headerCell = worksheet.Cells[1, i * 2 + 1, 1, i * 2 + 2];
                        headerCell.Value = RP.Columns[i].ColumnName;
                        headerCell.Merge = true;
                        headerCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    int currentRow = 2;
                    foreach (DataRow row in RP.Rows)
                    {
                        for (int i = 0; i < RP.Columns.Count; i++)
                        {
                            var dataCell = worksheet.Cells[currentRow, i * 2 + 1, currentRow, i * 2 + 2];
                            dataCell.Value = row[i];
                            dataCell.Merge = true;
                            dataCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }
                        currentRow++;
                    }

                    worksheet.Cells[2, 2, RP.Rows.Count + 1, 12].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                    worksheet.Cells[2, 13, RP.Rows.Count + 1, 14].Style.Numberformat.Format = "0.00";

                    worksheet.Cells.AutoFitColumns();

                    FileInfo excelFile = new FileInfo(filePath);
                    excel.SaveAs(excelFile);

                    MessageBox.Show("Datos exportados exitosamente a Excel en la ruta: " + filePath);
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Error al intentar acceder o guardar el archivo: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                DataTable datos = sqlclass.Datos(inicio.UsuarioSql, inicio.Contrasena);

                string FCA = DateTime.Now.ToString("yyyyMMdd");
                string baseFilePath = $@"D:\Todos los semestres de la uni\Universidad9\Gestion\Reportes\resultados_{FCA}";
                string filePath = baseFilePath + ".xlsx";
                int fileIndex = 1;

                while (File.Exists(filePath))
                {
                    filePath = $"{baseFilePath}_{fileIndex}.xlsx";
                    fileIndex++;
                }

                using (ExcelPackage excel = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Resultados");

                    for (int i = 0; i < datos.Columns.Count; i++)
                    {
                        var headerCell = worksheet.Cells[1, i * 2 + 1, 1, i * 2 + 2];
                        headerCell.Value = datos.Columns[i].ColumnName;
                        headerCell.Merge = true;
                        headerCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    for (int rowIndex = 0; rowIndex < datos.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < datos.Columns.Count; colIndex++)
                        {
                            var dataCell = worksheet.Cells[rowIndex + 2, colIndex * 2 + 1, rowIndex + 2, colIndex * 2 + 2];
                            dataCell.Value = datos.Rows[rowIndex][colIndex];
                            dataCell.Merge = true;
                            dataCell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }
                    }

                    worksheet.Cells[2, 2, datos.Rows.Count + 1, 12].Style.Numberformat.Format = "yyyy-MM-dd HH:mm:ss";
                    worksheet.Cells[2, 13, datos.Rows.Count + 1, 14].Style.Numberformat.Format = "0.00";

                    worksheet.Cells.AutoFitColumns();

                    FileInfo excelFile = new FileInfo(filePath);
                    excel.SaveAs(excelFile);

                    MessageBox.Show("Datos exportados exitosamente a Excel en la ruta: " + filePath);
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Error al intentar acceder o guardar el archivo: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }

        }
    }
}
