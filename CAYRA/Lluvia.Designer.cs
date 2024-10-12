
namespace CAYRA
{
    partial class Lluvia
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DTPinicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctAcAp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRefrecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctAcAp)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPinicio
            // 
            this.DTPinicio.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPinicio.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPinicio.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPinicio.Location = new System.Drawing.Point(12, 64);
            this.DTPinicio.Name = "DTPinicio";
            this.DTPinicio.Size = new System.Drawing.Size(377, 29);
            this.DTPinicio.TabIndex = 7;
            // 
            // DTPFin
            // 
            this.DTPFin.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPFin.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPFin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFin.Location = new System.Drawing.Point(605, 64);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(377, 29);
            this.DTPFin.TabIndex = 8;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbTitulo.Location = new System.Drawing.Point(46, 6);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(318, 55);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(672, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Fin";
            // 
            // ctAcAp
            // 
            this.ctAcAp.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ctAcAp.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctAcAp.Legends.Add(legend3);
            this.ctAcAp.Location = new System.Drawing.Point(11, 113);
            this.ctAcAp.Name = "ctAcAp";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.ctAcAp.Series.Add(series5);
            this.ctAcAp.Series.Add(series6);
            this.ctAcAp.Size = new System.Drawing.Size(982, 532);
            this.ctAcAp.TabIndex = 13;
            this.ctAcAp.Text = "chart1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(446, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 39);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRefrecar
            // 
            this.btnRefrecar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrecar.FlatAppearance.BorderSize = 0;
            this.btnRefrecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrecar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrecar.ForeColor = System.Drawing.Color.Black;
            this.btnRefrecar.Location = new System.Drawing.Point(446, 64);
            this.btnRefrecar.Name = "btnRefrecar";
            this.btnRefrecar.Size = new System.Drawing.Size(137, 39);
            this.btnRefrecar.TabIndex = 16;
            this.btnRefrecar.Text = "Refrescar";
            this.btnRefrecar.UseVisualStyleBackColor = true;
            this.btnRefrecar.Click += new System.EventHandler(this.btnRefrecar_Click);
            // 
            // Lluvia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(994, 646);
            this.Controls.Add(this.btnRefrecar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ctAcAp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPinicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lluvia";
            this.Text = "Lluvia";
            this.Load += new System.EventHandler(this.Lluvia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctAcAp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPinicio;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctActivo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctAcAp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRefrecar;
    }
}