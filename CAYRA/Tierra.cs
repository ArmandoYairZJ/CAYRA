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
    public partial class Tierra : Form
    {
        private SQLServerClass sqlclass;

        public Tierra()
        {
            InitializeComponent();
            this.sqlclass = new SQLServerClass();

        }

        private void Tierra_Load(object sender, EventArgs e)
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
            DataTable dtHuertoActivo = sqlclass.HuertoActivo(inicio.UsuarioSql, inicio.Contrasena);
            DataTable dtHuertoApagado = sqlclass.HuertoApagado(inicio.UsuarioSql, inicio.Contrasena);

            // Fechas y veces que se repiten lluvia activa
            DateTime[] FechaHuertoAC = dtHuertoActivo.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaHA"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] VecesHuertaAc = dtHuertoActivo.AsEnumerable()
                .Select(row => row.Field<int?>("VecesActivo"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Fechas y veces que se repiten lluvia apagada
            DateTime[] FechaHuertoAP = dtHuertoApagado.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaHAP"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] VecesHuertaAp = dtHuertoApagado.AsEnumerable()
                .Select(row => row.Field<int?>("VecesApagado"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Pasar los datos obtenidos a ConfigurarGrafico
            ConfigurarGrafico(FechaHuertoAC, VecesHuertaAc, FechaHuertoAP, VecesHuertaAp);
        }


        public void ConfigurarGrafico(DateTime[] FechaHuertoAC, int[] VecesHuertaAc, DateTime[] FechaHuertoAP, int[] VecesHuertaAp)
        {
            ctApagado.Series.Clear();

            // Crear serie para Huerto Activa
            Series serieLluviaActiva = new Series("Huerto Activa")
            {
                ChartType = SeriesChartType.Point,
                XValueType = ChartValueType.DateTime,
                MarkerSize = 20,
                MarkerStyle = MarkerStyle.Circle,
                Color = Color.Blue
            };

            // Agregar los puntos de datos para Huerto Activa
            for (int i = 0; i < FechaHuertoAC.Length; i++)
            {
                serieLluviaActiva.Points.AddXY(FechaHuertoAC[i], VecesHuertaAc[i]);
            }

            // Crear serie para Huerto Apagada
            Series serieLluviaApagada = new Series("Huerto Apagada")
            {
                ChartType = SeriesChartType.Point,
                XValueType = ChartValueType.DateTime,
                MarkerSize = 20,
                MarkerStyle = MarkerStyle.Cross,
                Color = Color.Red
            };

            // Agregar los puntos de datos para Huerto Apagada
            for (int i = 0; i < FechaHuertoAP.Length; i++)
            {
                serieLluviaApagada.Points.AddXY(FechaHuertoAP[i], VecesHuertaAp[i]);
            }

            // Agregar las series al Chart
            ctApagado.Series.Add(serieLluviaActiva);
            ctApagado.Series.Add(serieLluviaApagada);

            // Configurar el eje X para mostrar las fechas correctamente
            ctApagado.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            ctApagado.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            ctApagado.ChartAreas[0].AxisX.Title = "Fecha";

            // Configurar el eje Y para mostrar valores del 0 al 10
            ctApagado.ChartAreas[0].AxisY.Title = "Veces";
            ctApagado.ChartAreas[0].AxisY.Minimum = 0;
            ctApagado.ChartAreas[0].AxisY.Maximum = 10;
            ctApagado.ChartAreas[0].AxisY.Interval = 1;
        }

        //Guardar Grafico
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = "Grafico.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ctApagado.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
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

            DataTable dtHuertoActiva = sqlclass.HuertoActivoFH(inicio.UsuarioSql, inicio.Contrasena, fechaInicio, fechaFin);
            DataTable dtHuertoaApagada = sqlclass.HuertoApagadoFH(inicio.UsuarioSql, inicio.Contrasena, fechaInicio, fechaFin);


            // Fechas y veces que se repiten lluvia activa
            DateTime[] FechaHuertoAC = dtHuertoActiva.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaHA"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] VecesHuertaAc = dtHuertoActiva.AsEnumerable()
                .Select(row => row.Field<int?>("VecesActivo"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Fechas y veces que se repiten lluvia apagada
            DateTime[] FechaHuertoAP = dtHuertoaApagada.AsEnumerable()
                .Select(row => row.Field<DateTime?>("FechaHAP"))
                .Where(fecha => fecha.HasValue)
                .Select(fecha => fecha.Value)
                .ToArray();

            int[] VecesHuertaAp = dtHuertoaApagada.AsEnumerable()
                .Select(row => row.Field<int?>("VecesApagado"))
                .Where(veces => veces.HasValue)
                .Select(veces => veces.Value)
                .ToArray();

            // Pasar los datos obtenidos a ConfigurarGrafico
            ConfigurarGrafico(FechaHuertoAC, VecesHuertaAc, FechaHuertoAP, VecesHuertaAp);

        }
    }
}
