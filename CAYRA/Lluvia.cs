using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RDN;

namespace CAYRA
{
    public partial class Lluvia : Form
    {
        private SQLServerClass sqlclass;

        public Lluvia()
        {
            InitializeComponent();
            this.sqlclass = new SQLServerClass();

        }

        private void Lluvia_Load(object sender, EventArgs e)
        {
            try
            {
                sqlclass.SiHayConexion(inicio.UsuarioSql, inicio.Contrasena);
                ExtraDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}");
            }


        }


        public void ExtraDatos()
        {
            DataTable dtLluviaActiva = sqlclass.LluviaActivaDatos(inicio.UsuarioSql, inicio.Contrasena);
            DataTable dtLluviaApagada = sqlclass.LluviaApagadaDatos(inicio.UsuarioSql, inicio.Contrasena);

            // Fechas y veces que se repiten lluvia activa
            DateTime[] fechasLluviaActiva = dtLluviaActiva.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaA"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] vecesLluviaActiva = dtLluviaActiva.AsEnumerable()
                .Select(row => row.Field<int?>("VecesActivada"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Fechas y veces que se repiten lluvia apagada
            DateTime[] fechasLluviaApagada = dtLluviaApagada.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaAP"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] vecesLluviaApagada = dtLluviaApagada.AsEnumerable()
                .Select(row => row.Field<int?>("VecesApagada"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Pasar los datos obtenidos a ConfigurarGrafico
            ConfigurarGrafico(fechasLluviaActiva, vecesLluviaActiva, fechasLluviaApagada, vecesLluviaApagada);
        }


        public void ConfigurarGrafico(DateTime[] fechasLluviaActiva, int[] vecesLluviaActiva, DateTime[] fechasLluviaApagada, int[] vecesLluviaApagada)
        {
            ctAcAp.Series.Clear();

            // Crear serie para Lluvia Activa
            Series serieLluviaActiva = new Series("Lluvia Activa")
            {
                ChartType = SeriesChartType.Point,
                XValueType = ChartValueType.DateTime,
                MarkerSize = 20,
                MarkerStyle = MarkerStyle.Circle,
                Color = Color.Blue
            };

            // Agregar los puntos de datos para Lluvia Activa
            for (int i = 0; i < fechasLluviaActiva.Length; i++)
            {
                serieLluviaActiva.Points.AddXY(fechasLluviaActiva[i], vecesLluviaActiva[i]);
            }

            // Crear serie para Lluvia Apagada
            Series serieLluviaApagada = new Series("Lluvia Apagada")
            {
                ChartType = SeriesChartType.Point,
                XValueType = ChartValueType.DateTime,
                MarkerSize = 20,
                MarkerStyle = MarkerStyle.Cross,
                Color = Color.Red
            };

            // Agregar los puntos de datos para Lluvia Apagada
            for (int i = 0; i < fechasLluviaApagada.Length; i++)
            {
                serieLluviaApagada.Points.AddXY(fechasLluviaApagada[i], vecesLluviaApagada[i]);
            }

            // Agregar las series al Chart
            ctAcAp.Series.Add(serieLluviaActiva);
            ctAcAp.Series.Add(serieLluviaApagada);

            // Configurar el eje X para mostrar las fechas correctamente
            ctAcAp.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            ctAcAp.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            ctAcAp.ChartAreas[0].AxisX.Title = "Fecha";

            // Configurar el eje Y para mostrar valores del 0 al 10
            ctAcAp.ChartAreas[0].AxisY.Title = "Veces";
            ctAcAp.ChartAreas[0].AxisY.Minimum = 0;
            ctAcAp.ChartAreas[0].AxisY.Maximum = 10;
            ctAcAp.ChartAreas[0].AxisY.Interval = 1;
        }

        //Guardar Grafico
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "Grafico.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ctAcAp.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        MessageBox.Show("Se guardo la grafica: " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar la gráfica: " + ex.Message);
                    }
                }
            }
        }

        private void btnRefrecar_Click(object sender, EventArgs e)
        {
            // Obtener las fechas de inicio y fin desde los DateTimePicker
            DateTime fechaInicio = DTPinicio.Value.Date;
            DateTime fechaFin = DTPFin.Value.Date;

            DataTable dtLluviaActiva = sqlclass.LluviaAFecha(inicio.UsuarioSql, inicio.Contrasena, fechaInicio, fechaFin);
            DataTable dtLluviaApagada = sqlclass.LluviaAPFecha(inicio.UsuarioSql, inicio.Contrasena, fechaInicio, fechaFin);

            // Fechas y veces que se repiten lluvia activa
            DateTime[] fechasLluviaActiva = dtLluviaActiva.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaA"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] vecesLluviaActiva = dtLluviaActiva.AsEnumerable()
                .Select(row => row.Field<int?>("VecesActivada"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Fechas y veces que se repiten lluvia apagada
            DateTime[] fechasLluviaApagada = dtLluviaApagada.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaAP"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] vecesLluviaApagada = dtLluviaApagada.AsEnumerable()
                .Select(row => row.Field<int?>("VecesApagada"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Pasar los datos obtenidos a ConfigurarGrafico
            ConfigurarGrafico(fechasLluviaActiva, vecesLluviaActiva, fechasLluviaApagada, vecesLluviaApagada);

        }
    }
}
