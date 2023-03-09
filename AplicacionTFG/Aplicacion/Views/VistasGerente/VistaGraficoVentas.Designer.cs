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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graficoVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnVolver = new Presentacion.Controllers.BotonRedondeadoPropio();
            this.btnCambiarGrafico = new Presentacion.Controllers.BotonRedondeadoPropio();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // graficoVendedores
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoVendedores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoVendedores.Legends.Add(legend2);
            this.graficoVendedores.Location = new System.Drawing.Point(-1, 0);
            this.graficoVendedores.Name = "graficoVendedores";
            this.graficoVendedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            series2.YValuesPerPoint = 4;
            this.graficoVendedores.Series.Add(series2);
            this.graficoVendedores.Size = new System.Drawing.Size(535, 516);
            this.graficoVendedores.TabIndex = 0;
            this.graficoVendedores.Text = "chart1";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolver.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVolver.BorderColor = System.Drawing.Color.Coral;
            this.btnVolver.BorderRadius = 0;
            this.btnVolver.BorderSize = 0;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(551, 428);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCambiarGrafico
            // 
            this.btnCambiarGrafico.BackColor = System.Drawing.Color.Coral;
            this.btnCambiarGrafico.BackgroundColor = System.Drawing.Color.Coral;
            this.btnCambiarGrafico.BorderColor = System.Drawing.Color.Coral;
            this.btnCambiarGrafico.BorderRadius = 0;
            this.btnCambiarGrafico.BorderSize = 0;
            this.btnCambiarGrafico.FlatAppearance.BorderSize = 0;
            this.btnCambiarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarGrafico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCambiarGrafico.ForeColor = System.Drawing.Color.White;
            this.btnCambiarGrafico.Location = new System.Drawing.Point(551, 367);
            this.btnCambiarGrafico.Name = "btnCambiarGrafico";
            this.btnCambiarGrafico.Size = new System.Drawing.Size(150, 40);
            this.btnCambiarGrafico.TabIndex = 1;
            this.btnCambiarGrafico.Text = "Gráfico Columna";
            this.btnCambiarGrafico.TextColor = System.Drawing.Color.White;
            this.btnCambiarGrafico.UseVisualStyleBackColor = false;
            this.btnCambiarGrafico.Click += new System.EventHandler(this.botonRedondeadoPropio1_Click);
            // 
            // VistaGraficoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 500);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCambiarGrafico);
            this.Controls.Add(this.graficoVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 500);
            this.Name = "VistaGraficoVentas";
            this.Text = "VistaGraficoVentas";
            ((System.ComponentModel.ISupportInitialize)(this.graficoVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVendedores;
        private Controllers.BotonRedondeadoPropio btnCambiarGrafico;
        private Controllers.BotonRedondeadoPropio btnVolver;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}