
namespace CAYRA
{
    partial class inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.PLateral = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnTierra = new System.Windows.Forms.Button();
            this.btnLLuvia = new System.Windows.Forms.Button();
            this.PLArriba = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.PLCentral = new System.Windows.Forms.Panel();
            this.PLateral.SuspendLayout();
            this.PLArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // PLateral
            // 
            this.PLateral.BackColor = System.Drawing.Color.Chocolate;
            this.PLateral.Controls.Add(this.btnInicio);
            this.PLateral.Controls.Add(this.lbTitulo);
            this.PLateral.Controls.Add(this.btnReporte);
            this.PLateral.Controls.Add(this.btnTierra);
            this.PLateral.Controls.Add(this.btnLLuvia);
            this.PLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLateral.Location = new System.Drawing.Point(0, 0);
            this.PLateral.Name = "PLateral";
            this.PLateral.Size = new System.Drawing.Size(225, 676);
            this.PLateral.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Chocolate;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Transparent;
            this.btnInicio.Image = global::CAYRA.Properties.Resources.casa1;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.Location = new System.Drawing.Point(3, 81);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(216, 116);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(3, 1);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(213, 55);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "CAYRA";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Chocolate;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = global::CAYRA.Properties.Resources.reporte;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte.Location = new System.Drawing.Point(6, 548);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(216, 116);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnTierra
            // 
            this.btnTierra.BackColor = System.Drawing.Color.Chocolate;
            this.btnTierra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTierra.FlatAppearance.BorderSize = 0;
            this.btnTierra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTierra.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTierra.ForeColor = System.Drawing.Color.White;
            this.btnTierra.Image = global::CAYRA.Properties.Resources.tierra;
            this.btnTierra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTierra.Location = new System.Drawing.Point(6, 377);
            this.btnTierra.Name = "btnTierra";
            this.btnTierra.Size = new System.Drawing.Size(216, 116);
            this.btnTierra.TabIndex = 1;
            this.btnTierra.Text = "TIERRA";
            this.btnTierra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTierra.UseVisualStyleBackColor = false;
            this.btnTierra.Click += new System.EventHandler(this.btnTierra_Click);
            // 
            // btnLLuvia
            // 
            this.btnLLuvia.BackColor = System.Drawing.Color.Chocolate;
            this.btnLLuvia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLLuvia.FlatAppearance.BorderSize = 0;
            this.btnLLuvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLLuvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLLuvia.ForeColor = System.Drawing.Color.White;
            this.btnLLuvia.Image = global::CAYRA.Properties.Resources.ll;
            this.btnLLuvia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLLuvia.Location = new System.Drawing.Point(3, 216);
            this.btnLLuvia.Name = "btnLLuvia";
            this.btnLLuvia.Size = new System.Drawing.Size(216, 116);
            this.btnLLuvia.TabIndex = 0;
            this.btnLLuvia.Text = "LLUVIA";
            this.btnLLuvia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLLuvia.UseVisualStyleBackColor = false;
            this.btnLLuvia.Click += new System.EventHandler(this.btnLLuvia_Click);
            // 
            // PLArriba
            // 
            this.PLArriba.BackColor = System.Drawing.Color.DarkKhaki;
            this.PLArriba.Controls.Add(this.picMinimizar);
            this.PLArriba.Controls.Add(this.PicSalir);
            this.PLArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLArriba.Location = new System.Drawing.Point(225, 0);
            this.PLArriba.Name = "PLArriba";
            this.PLArriba.Size = new System.Drawing.Size(994, 30);
            this.PLArriba.TabIndex = 1;
            // 
            // picMinimizar
            // 
            this.picMinimizar.Image = global::CAYRA.Properties.Resources.minimizar_signo;
            this.picMinimizar.Location = new System.Drawing.Point(928, 1);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(30, 29);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMinimizar.TabIndex = 1;
            this.picMinimizar.TabStop = false;
            this.picMinimizar.Click += new System.EventHandler(this.picMinimizar_Click);
            // 
            // PicSalir
            // 
            this.PicSalir.Image = global::CAYRA.Properties.Resources.x2;
            this.PicSalir.Location = new System.Drawing.Point(964, 1);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(30, 29);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // PLCentral
            // 
            this.PLCentral.BackColor = System.Drawing.Color.DarkKhaki;
            this.PLCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLCentral.Location = new System.Drawing.Point(225, 30);
            this.PLCentral.Name = "PLCentral";
            this.PLCentral.Size = new System.Drawing.Size(994, 646);
            this.PLCentral.TabIndex = 2;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1219, 676);
            this.Controls.Add(this.PLCentral);
            this.Controls.Add(this.PLArriba);
            this.Controls.Add(this.PLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.PLateral.ResumeLayout(false);
            this.PLateral.PerformLayout();
            this.PLArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLateral;
        private System.Windows.Forms.Panel PLArriba;
        private System.Windows.Forms.PictureBox PicSalir;
        private System.Windows.Forms.Panel PLCentral;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnTierra;
        private System.Windows.Forms.Button btnLLuvia;
        private System.Windows.Forms.Button btnInicio;
    }
}