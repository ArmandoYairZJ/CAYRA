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
    public partial class inicio : Form
    {
        private SQLServerClass sqlclass;

        public static string UsuarioSql { get; set; }
        public static string Contrasena { get; set; }


        public inicio()
        {
            InitializeComponent();
            this.sqlclass = new SQLServerClass();

        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Crear paneles hijos
        

        public void abrirHijos(object formHijo)
        {
            if (this.PLCentral.Controls.Count > 0)
            {
                Form formularioActivo = this.PLCentral.Controls[0] as Form; 
                if (formularioActivo != null)
                {
                    formularioActivo.Close(); 
                }
            }

            Form FH = formHijo as Form; 
            FH.TopLevel = false; 
            FH.Dock = DockStyle.Fill; 
            this.PLCentral.Controls.Add(FH); 
            this.PLCentral.Tag = FH; 
            FH.Show(); 

        }

        public void btnLLuvia_Click(object sender, EventArgs e)
        {
            abrirHijos(new Lluvia());
        }

        public void btnTierra_Click(object sender, EventArgs e)
        {
            abrirHijos(new Tierra());
        }

        public void btnReporte_Click(object sender, EventArgs e)
        {
            abrirHijos(new Reporte());
        }

        public void btnInicio_Click(object sender, EventArgs e)
        {
            abrirHijos(new IN());
        }

        // Carga de datos
        private void inicio_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
            sqlclass.SiHayConexion(inicio.UsuarioSql, inicio.Contrasena);
        }


    }
}
