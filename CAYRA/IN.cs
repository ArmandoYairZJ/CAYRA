using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDN;

namespace CAYRA
{
    public partial class IN : Form
    {

        private SQLServerClass sqlclass;
        SerialPort Luz;
        SerialPort Ciclo;
        bool IsClosed = false;

        public IN()
        {
            InitializeComponent();
            this.sqlclass = new SQLServerClass();

            //Datos enviandos por el serial de la luz
            Luz = new SerialPort("COM5", 115200);
            Luz.ReadTimeout = 500;
            Ciclo = new SerialPort("COM6", 9600);
            Ciclo.ReadTimeout = 500;

            try
            {
                Ciclo.Open();
                Luz.Open();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con el puerto serial: " + ex.Message);
                MessageBox.Show("Error al conectar con el puerto serial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        


        }


        //Escuchados los datos por el serial para ingresarlos en la db 
        public void EscucharLuz()
        {
            while (!IsClosed)
            {
                try
                {
                    string Lz = Luz.ReadLine();
                    txbLuz.Invoke(new MethodInvoker(() =>
                    {
                        txbLuz.Text = Lz;
                    }));
                }
                catch (TimeoutException) { /* Ignorar la excepción de timeout */ }
                catch (InvalidOperationException) { /* Ignorar la excepción si el puerto se ha cerrado */ }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer del puerto serial: " + ex.Message);
                }
            }
        }

        public void EscucharCiclo()
        {
            while (!IsClosed)
            {
                try
                {
                    string cl = Ciclo.ReadLine();
                    txtbEstados.Invoke(new MethodInvoker(() =>
                    {
                        txtbEstados.Text = cl;
                    }));
                }
                catch (TimeoutException) { /* Ignorar la excepción de timeout */ }
                catch (InvalidOperationException) { /* Ignorar la excepción si el puerto se ha cerrado */ }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer del puerto serial: " + ex.Message);
                }
            }
        }




        public void FecH()
        {
            var FechH = DateTime.Now;
            txtFecha.Text = FechH.ToString("hh:mm tt dd/MM/yyyy");
        }



        //Mostrar el estado en el momento
        private int? ultimoestado = null;
        private string UTI = "";

        public void txtbEstados_TextChanged(object sender, EventArgs e)
        {
            if (txtbEstados.Text == UTI)
            {
                return;
            }

            UTI = txtbEstados.Text;

            DateTime Now = DateTime.Now;
            int estado;

            if (int.TryParse(txtbEstados.Text, out estado))
            {
                string est = "";

                try
                {
                    switch (estado)
                    {
                        case 0:
                            est = "Está lloviendo";
                            sqlclass.LluviaActiva(inicio.UsuarioSql, inicio.Contrasena, Now);
                            break;

                        case 1:
                            est = "Ya no está lloviendo";
                            sqlclass.LluviaApagada(inicio.UsuarioSql, inicio.Contrasena, Now);
                            break;

                        case 3:
                            est = "Se prendió la bomba";
                            sqlclass.HuertoActivo(inicio.UsuarioSql, inicio.Contrasena, Now);
                            break;

                        case 2:
                            est = "Se apagó la bomba";
                            sqlclass.HuertoApagado(inicio.UsuarioSql, inicio.Contrasena, Now);
                            break;

                        default:
                            est = "Ha ocurrido algún error ";
                            break;
                    }

                    if (estado != ultimoestado)
                    {
                        DGVUltimo.Rows.Add(estado, est);
                        ultimoestado = estado;
                    }

                    txtbTipoEstado.Text = est;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el dato: " + ex.Message);
                }
            }
            else
            {
                txtbTipoEstado.Text = "Por el momento no hay ningún estado";
            }

        }

        private void txbLuz_TextChanged(object sender, EventArgs e)
        {
            string Dt = txbLuz.Text;
            float valor;
            DateTime Now = DateTime.Now;


            if (float.TryParse(Dt, out valor))
            {
                try {

                    sqlclass.NivelLuz(inicio.UsuarioSql, inicio.Contrasena, valor, Now);
                    txtbNLux.Text = ($"El nivel de luminosidad es de {valor}");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar el dato: {ex.Message}");

                }
            }

            else
            {
                MessageBox.Show("Todavia no se ingresa ningun dato");

            }
        }

      



        private void IN_Load(object sender, EventArgs e)
        {

           
            try
            {
               
                FecH();
                txtbEstados.TextChanged += new EventHandler(txtbEstados_TextChanged);
                sqlclass.SiHayConexion(inicio.UsuarioSql, inicio.Contrasena);

                // Abre los puertos solo si no están abiertos
                if (!Luz.IsOpen)
                {
                    Luz.Open();
                }

                if (!Ciclo.IsOpen)
                {
                    Ciclo.Open();
                }

                // Iniciar los hilos
                if (Luz.IsOpen || Ciclo.IsOpen)
                {
                    Thread Hilo = new Thread(EscucharLuz);
                    Hilo.Start();
                    Thread HL = new Thread(EscucharCiclo);
                    HL.Start();
                }

                    else
                {
                    Console.WriteLine("El puerto serial no está abierto.");
                    MessageBox.Show("El puerto serial no está abierto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DestruirConexiones()
        {
            IsClosed = true;  // Indica que los hilos deben detenerse

            // Cerrar los puertos si están abiertos
            if (Luz != null)
            {
                if (Luz.IsOpen)
                {
                    Luz.Close();
                }
                Luz.Dispose();  
                Luz = null;    
            }

            if (Ciclo != null)
            {
                if (Ciclo.IsOpen)
                {
                    Ciclo.Close();
                }
                Ciclo.Dispose();  
                Ciclo = null;    
            }
        }


        private void IN_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DestruirConexiones();
        
        }
    }
}
