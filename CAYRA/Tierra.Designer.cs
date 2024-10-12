
namespace CAYRA
{
    partial class Tierra
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.ctApagado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.DTPinicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRefrecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctApagado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(659, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha Fin";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbTitulo.Location = new System.Drawing.Point(43, 5);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(318, 55);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Fecha Inicio";
            // 
            // ctApagado
            // 
            this.ctApagado.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ctApagado.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ctApagado.Legends.Add(legend2);
            this.ctApagado.Location = new System.Drawing.Point(-1, 98);
            this.ctApagado.Name = "ctApagado";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Black;
            series3.MarkerSize = 8;
            series3.Name = "Activo";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.SteelBlue;
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "Apagado";
            this.ctApagado.Series.Add(series3);
            this.ctApagado.Series.Add(series4);
            this.ctApagado.Size = new System.Drawing.Size(996, 543);
            this.ctApagado.TabIndex = 15;
            this.ctApagado.Text = "chart1";
            // 
            // DTPFin
            // 
            this.DTPFin.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPFin.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPFin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFin.Location = new System.Drawing.Point(608, 63);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(377, 29);
            this.DTPFin.TabIndex = 14;
            // 
            // DTPinicio
            // 
            this.DTPinicio.CalendarForeColor = System.Drawing.Color.Black;
            this.DTPinicio.CalendarMonthBackground = System.Drawing.Color.DarkKhaki;
            this.DTPinicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPinicio.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPinicio.Location = new System.Drawing.Point(12, 63);
            this.DTPinicio.Name = "DTPinicio";
            this.DTPinicio.Size = new System.Drawing.Size(377, 29);
            this.DTPinicio.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(427, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 39);
            this.btnGuardar.TabIndex = 20;
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
            this.btnRefrecar.Location = new System.Drawing.Point(427, 53);
            this.btnRefrecar.Name = "btnRefrecar";
            this.btnRefrecar.Size = new System.Drawing.Size(137, 39);
            this.btnRefrecar.TabIndex = 21;
            this.btnRefrecar.Text = "Refrescar";
            this.btnRefrecar.UseVisualStyleBackColor = true;
            this.btnRefrecar.Click += new System.EventHandler(this.btnRefrecar_Click);
            // 
            // Tierra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(994, 646);
            this.Controls.Add(this.btnRefrecar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ctApagado);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPinicio);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tierra";
            this.Text = "Tierra";
            this.Load += new System.EventHandler(this.Tierra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctApagado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctApagado;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.DateTimePicker DTPinicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRefrecar;
    }
}