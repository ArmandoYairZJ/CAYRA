
namespace CAYRA
{
    partial class IN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IN));
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtbEstados = new System.Windows.Forms.TextBox();
            this.LbEstados = new System.Windows.Forms.Label();
            this.txtbTipoEstado = new System.Windows.Forms.TextBox();
            this.DGVUltimo = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbLuz = new System.Windows.Forms.TextBox();
            this.txtbNLux = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUltimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(1, 574);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(994, 93);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbEstados
            // 
            this.txtbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEstados.Location = new System.Drawing.Point(12, 100);
            this.txtbEstados.Name = "txtbEstados";
            this.txtbEstados.Size = new System.Drawing.Size(308, 38);
            this.txtbEstados.TabIndex = 2;
            this.txtbEstados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbEstados.TextChanged += new System.EventHandler(this.txtbEstados_TextChanged);
            // 
            // LbEstados
            // 
            this.LbEstados.AutoSize = true;
            this.LbEstados.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstados.Location = new System.Drawing.Point(35, 42);
            this.LbEstados.Name = "LbEstados";
            this.LbEstados.Size = new System.Drawing.Size(269, 55);
            this.LbEstados.TabIndex = 3;
            this.LbEstados.Text = "ESTADOS";
            // 
            // txtbTipoEstado
            // 
            this.txtbTipoEstado.Enabled = false;
            this.txtbTipoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTipoEstado.Location = new System.Drawing.Point(12, 153);
            this.txtbTipoEstado.Multiline = true;
            this.txtbTipoEstado.Name = "txtbTipoEstado";
            this.txtbTipoEstado.Size = new System.Drawing.Size(308, 125);
            this.txtbTipoEstado.TabIndex = 4;
            this.txtbTipoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGVUltimo
            // 
            this.DGVUltimo.AllowUserToDeleteRows = false;
            this.DGVUltimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUltimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Descripcion});
            this.DGVUltimo.Location = new System.Drawing.Point(600, 100);
            this.DGVUltimo.Name = "DGVUltimo";
            this.DGVUltimo.ReadOnly = true;
            this.DGVUltimo.Size = new System.Drawing.Size(395, 445);
            this.DGVUltimo.TabIndex = 5;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txbLuz
            // 
            this.txbLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuz.Location = new System.Drawing.Point(328, 100);
            this.txbLuz.Name = "txbLuz";
            this.txbLuz.Size = new System.Drawing.Size(266, 38);
            this.txbLuz.TabIndex = 7;
            this.txbLuz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLuz.TextChanged += new System.EventHandler(this.txbLuz_TextChanged);
            // 
            // txtbNLux
            // 
            this.txtbNLux.Enabled = false;
            this.txtbNLux.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNLux.Location = new System.Drawing.Point(326, 153);
            this.txtbNLux.Multiline = true;
            this.txtbNLux.Name = "txtbNLux";
            this.txtbNLux.Size = new System.Drawing.Size(268, 125);
            this.txtbNLux.TabIndex = 8;
            this.txtbNLux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "LUZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "ACTIVIDAD";
            // 
            // IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(994, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNLux);
            this.Controls.Add(this.txbLuz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGVUltimo);
            this.Controls.Add(this.txtbTipoEstado);
            this.Controls.Add(this.LbEstados);
            this.Controls.Add(this.txtbEstados);
            this.Controls.Add(this.txtFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IN";
            this.Text = "IN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IN_FormClosing_1);
            this.Load += new System.EventHandler(this.IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUltimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtbEstados;
        private System.Windows.Forms.Label LbEstados;
        private System.Windows.Forms.TextBox txtbTipoEstado;
        private System.Windows.Forms.DataGridView DGVUltimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbLuz;
        private System.Windows.Forms.TextBox txtbNLux;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}