
namespace CAYRA
{
    partial class Reporte
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
            this.DGVReporte = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnReporteFecha = new System.Windows.Forms.Button();
            this.DTPinicio = new System.Windows.Forms.DateTimePicker();
            this.DTPfin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReporte
            // 
            this.DGVReporte.AllowUserToDeleteRows = false;
            this.DGVReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReporte.Location = new System.Drawing.Point(12, 70);
            this.DGVReporte.Name = "DGVReporte";
            this.DGVReporte.ReadOnly = true;
            this.DGVReporte.Size = new System.Drawing.Size(970, 498);
            this.DGVReporte.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Location = new System.Drawing.Point(142, 585);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(258, 49);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnReporteFecha
            // 
            this.btnReporteFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteFecha.FlatAppearance.BorderSize = 0;
            this.btnReporteFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteFecha.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteFecha.ForeColor = System.Drawing.Color.Black;
            this.btnReporteFecha.Location = new System.Drawing.Point(494, 585);
            this.btnReporteFecha.Name = "btnReporteFecha";
            this.btnReporteFecha.Size = new System.Drawing.Size(408, 49);
            this.btnReporteFecha.TabIndex = 5;
            this.btnReporteFecha.Text = "Reporte Por Fecha";
            this.btnReporteFecha.UseVisualStyleBackColor = true;
            this.btnReporteFecha.Click += new System.EventHandler(this.btnReporteFecha_Click);
            // 
            // DTPinicio
            // 
            this.DTPinicio.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPinicio.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPinicio.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPinicio.Location = new System.Drawing.Point(23, 24);
            this.DTPinicio.Name = "DTPinicio";
            this.DTPinicio.Size = new System.Drawing.Size(377, 29);
            this.DTPinicio.TabIndex = 6;
            // 
            // DTPfin
            // 
            this.DTPfin.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPfin.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPfin.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DTPfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPfin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPfin.Location = new System.Drawing.Point(579, 24);
            this.DTPfin.Name = "DTPfin";
            this.DTPfin.Size = new System.Drawing.Size(377, 29);
            this.DTPfin.TabIndex = 7;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(994, 646);
            this.Controls.Add(this.DTPfin);
            this.Controls.Add(this.DTPinicio);
            this.Controls.Add(this.btnReporteFecha);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.DGVReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnReporteFecha;
        private System.Windows.Forms.DateTimePicker DTPinicio;
        private System.Windows.Forms.DateTimePicker DTPfin;
    }
}