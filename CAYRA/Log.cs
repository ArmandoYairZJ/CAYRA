using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RDN;

namespace CAYRA
{
    public partial class LOG : Form
    {

        public static string usbDB { get; set; }
        public static string conDB { get; set; }
        //Mostrar contraseña
        public bool see = false;
        public LOG()
        {
            InitializeComponent();
            int radius = 30; 
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 190, 100); 
            path.AddArc(Width - radius, 0, radius, radius, 280, 100);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 100); 
            path.AddArc(0, Height - radius, radius, radius, 100, 100); 
            path.CloseFigure();
            this.Region = new Region(path);
        }
       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //ocultar y ver contraseña
        private void pbVer_Click(object sender, EventArgs e)
        {
            see = !see;

            if(see)
            {
                txtbCon.PasswordChar = '\0';
                pbVer.Image = CAYRA.Properties.Resources.nove;
            }

            else
            {
                txtbCon.PasswordChar = '*';
                pbVer.Image = CAYRA.Properties.Resources.ve;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            openPr(); 
        }

        //Login
        private SQLServerClass sDB = new SQLServerClass();
        public bool Resuelto = false;
        public Boolean bUsuarioCorrecto = false;

        public void openPr()
        {
            

            try
            {
                if (!sDB.SiHayConexion(txtbUs.Text, txtbCon.Text))
                {

                    MessageBox.Show(
                        "Error: No se pudo establecer la conexión." + Environment.NewLine + "Verifique usuario y contraseña.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    clear();
                }

                else
                {
                    SQLServerClass cone = new SQLServerClass();
                    try
                    {
                        if (sDB.SiHayConexion(txtbUs.Text, txtbCon.Text))
                        {

                            MessageBox.Show(
                                    "La conexión se ha establecido correctamente." + Environment.NewLine + "Pudo ingresar con éxito.",
                                    "Datos Correctos",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                            inicio.UsuarioSql = txtbUs.Text;
                            inicio.Contrasena = txtbCon.Text;
                            bUsuarioCorrecto = true;
                            Resuelto = true;
                            this.Close();
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(cone.sLastError);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }


        public void clear()
        {
            txtbCon.Text = string.Empty;
            txtbUs.Text = string.Empty;
        }
    }
}
