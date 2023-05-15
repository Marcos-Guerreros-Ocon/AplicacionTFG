namespace Presentacion.Views.VistasGerente
{
    partial class VistaVentasGerente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaVentasGerente));
            this.tablaVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVistaGrafico = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInforme = new Guna.UI2.WinForms.Guna2Button();
            this.btnFiltroAutor = new Guna.UI2.WinForms.Guna2Button();
            this.btnReiniciar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToAddRows = false;
            this.tablaVentas.AllowUserToDeleteRows = false;
            this.tablaVentas.AllowUserToResizeColumns = false;
            this.tablaVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Titulo,
            this.Autor,
            this.Nombre,
            this.Apellidos,
            this.Correo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaVentas.Location = new System.Drawing.Point(90, 228);
            this.tablaVentas.MultiSelect = false;
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.ReadOnly = true;
            this.tablaVentas.RowHeadersVisible = false;
            this.tablaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaVentas.Size = new System.Drawing.Size(770, 374);
            this.tablaVentas.TabIndex = 16;
            this.tablaVentas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.tablaVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.tablaVentas.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tablaVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaVentas.ThemeStyle.HeaderStyle.Height = 23;
            this.tablaVentas.ThemeStyle.ReadOnly = true;
            this.tablaVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.tablaVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablaVentas.ThemeStyle.RowsStyle.Height = 22;
            this.tablaVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.tablaVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 70;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Titulo.FillWeight = 396.9072F;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 78;
            // 
            // Autor
            // 
            this.Autor.FillWeight = 25.77319F;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 25.77319F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellidos
            // 
            this.Apellidos.FillWeight = 25.77319F;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 25.77319F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.IconRight = global::Presentacion.Properties.Resources.search;
            this.txtBuscar.Location = new System.Drawing.Point(660, 157);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(200, 36);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnVistaGrafico
            // 
            this.btnVistaGrafico.BorderRadius = 10;
            this.btnVistaGrafico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVistaGrafico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVistaGrafico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVistaGrafico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVistaGrafico.FillColor = System.Drawing.Color.Coral;
            this.btnVistaGrafico.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVistaGrafico.ForeColor = System.Drawing.Color.White;
            this.btnVistaGrafico.Location = new System.Drawing.Point(740, 622);
            this.btnVistaGrafico.Name = "btnVistaGrafico";
            this.btnVistaGrafico.Size = new System.Drawing.Size(120, 45);
            this.btnVistaGrafico.TabIndex = 17;
            this.btnVistaGrafico.Text = "Vista Gráfico";
            this.btnVistaGrafico.Click += new System.EventHandler(this.btnVistaGrafico_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(833, 445);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.Visible = false;
            // 
            // btnInforme
            // 
            this.btnInforme.BorderRadius = 10;
            this.btnInforme.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInforme.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInforme.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInforme.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInforme.FillColor = System.Drawing.Color.Coral;
            this.btnInforme.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInforme.ForeColor = System.Drawing.Color.White;
            this.btnInforme.Location = new System.Drawing.Point(90, 622);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(166, 45);
            this.btnInforme.TabIndex = 20;
            this.btnInforme.Text = "Generar Informe";
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnFiltroAutor
            // 
            this.btnFiltroAutor.BorderRadius = 10;
            this.btnFiltroAutor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroAutor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltroAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltroAutor.FillColor = System.Drawing.Color.Coral;
            this.btnFiltroAutor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFiltroAutor.ForeColor = System.Drawing.Color.White;
            this.btnFiltroAutor.Location = new System.Drawing.Point(69, 72);
            this.btnFiltroAutor.Name = "btnFiltroAutor";
            this.btnFiltroAutor.Size = new System.Drawing.Size(120, 45);
            this.btnFiltroAutor.TabIndex = 11;
            this.btnFiltroAutor.Text = "Autor";
            this.btnFiltroAutor.Click += new System.EventHandler(this.btnFiltroAutor_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BorderRadius = 10;
            this.btnReiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReiniciar.FillColor = System.Drawing.Color.Coral;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(782, 72);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(120, 45);
            this.btnReiniciar.TabIndex = 21;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // VistaVentasGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnFiltroAutor);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVistaGrafico);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.txtBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaVentasGerente";
            this.Text = "Dispositivos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView tablaVentas;
        private Guna.UI2.WinForms.Guna2Button btnVistaGrafico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnInforme;
        private Guna.UI2.WinForms.Guna2Button btnFiltroAutor;
        private Guna.UI2.WinForms.Guna2Button btnReiniciar;
    }
}