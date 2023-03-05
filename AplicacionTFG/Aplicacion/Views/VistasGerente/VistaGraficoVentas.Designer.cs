namespace Presentacion.Views.VistasGerente
{
    partial class VistaGraficoVentas
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.botonRedondeadoPropio1 = new Presentacion.Controllers.BotonRedondeadoPropio();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoVendedores
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoVendedores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoVendedores.Legends.Add(legend2);
            this.graficoVendedores.Location = new System.Drawing.Point(74, 48);
            this.graficoVendedores.Name = "graficoVendedores";
            this.graficoVendedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoVendedores.Series.Add(series2);
            this.graficoVendedores.Size = new System.Drawing.Size(411, 353);
            this.graficoVendedores.TabIndex = 0;
            this.graficoVendedores.Text = "chart1";
            // 
            // botonRedondeadoPropio1
            // 
            this.botonRedondeadoPropio1.BackColor = System.Drawing.Color.Coral;
            this.botonRedondeadoPropio1.BackgroundColor = System.Drawing.Color.Coral;
            this.botonRedondeadoPropio1.BorderColor = System.Drawing.Color.Coral;
            this.botonRedondeadoPropio1.BorderRadius = 0;
            this.botonRedondeadoPropio1.BorderSize = 0;
            this.botonRedondeadoPropio1.FlatAppearance.BorderSize = 0;
            this.botonRedondeadoPropio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondeadoPropio1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.botonRedondeadoPropio1.ForeColor = System.Drawing.Color.White;
            this.botonRedondeadoPropio1.Location = new System.Drawing.Point(562, 302);
            this.botonRedondeadoPropio1.Name = "botonRedondeadoPropio1";
            this.botonRedondeadoPropio1.Size = new System.Drawing.Size(150, 40);
            this.botonRedondeadoPropio1.TabIndex = 1;
            this.botonRedondeadoPropio1.Text = "botonRedondeadoPropio1";
            this.botonRedondeadoPropio1.TextColor = System.Drawing.Color.White;
            this.botonRedondeadoPropio1.UseVisualStyleBackColor = false;
            this.botonRedondeadoPropio1.Click += new System.EventHandler(this.botonRedondeadoPropio1_Click);
            // 
            // VistaGraficoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonRedondeadoPropio1);
            this.Controls.Add(this.graficoVendedores);
            this.Name = "VistaGraficoVentas";
            this.Text = "VistaGraficoVentas";
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVendedores;
        private Controllers.BotonRedondeadoPropio botonRedondeadoPropio1;
    }
}