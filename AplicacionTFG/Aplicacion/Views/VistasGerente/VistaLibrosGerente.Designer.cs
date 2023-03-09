namespace Presentacion.Views.VistasGerente
{
    partial class VistaLibrosGerente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltroGenero = new Guna.UI2.WinForms.Guna2Button();
            this.btnFiltroPrecio = new Guna.UI2.WinForms.Guna2Button();
            this.btnFiltroAutor = new Guna.UI2.WinForms.Guna2Button();
            this.btnReiniciar = new Guna.UI2.WinForms.Guna2Button();
            this.btnFiltroStock = new Guna.UI2.WinForms.Guna2Button();
            this.tablaLibros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltroGenero
            // 
            this.btnFiltroGenero.BorderRadius = 10;
            this.btnFiltroGenero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroGenero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroGenero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltroGenero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltroGenero.FillColor = System.Drawing.Color.Coral;
            this.btnFiltroGenero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFiltroGenero.ForeColor = System.Drawing.Color.White;
            this.btnFiltroGenero.Location = new System.Drawing.Point(90, 50);
            this.btnFiltroGenero.Name = "btnFiltroGenero";
            this.btnFiltroGenero.Size = new System.Drawing.Size(120, 45);
            this.btnFiltroGenero.TabIndex = 10;
            this.btnFiltroGenero.Text = "Genero";
            this.btnFiltroGenero.Click += new System.EventHandler(this.btnFiltroGenero_Click);
            // 
            // btnFiltroPrecio
            // 
            this.btnFiltroPrecio.BorderRadius = 10;
            this.btnFiltroPrecio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroPrecio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltroPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltroPrecio.FillColor = System.Drawing.Color.Coral;
            this.btnFiltroPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFiltroPrecio.ForeColor = System.Drawing.Color.White;
            this.btnFiltroPrecio.Location = new System.Drawing.Point(350, 50);
            this.btnFiltroPrecio.Name = "btnFiltroPrecio";
            this.btnFiltroPrecio.Size = new System.Drawing.Size(120, 45);
            this.btnFiltroPrecio.TabIndex = 11;
            this.btnFiltroPrecio.Text = "Precio";
            this.btnFiltroPrecio.Click += new System.EventHandler(this.btnFiltroPrecio_Click);
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
            this.btnFiltroAutor.Location = new System.Drawing.Point(220, 50);
            this.btnFiltroAutor.Name = "btnFiltroAutor";
            this.btnFiltroAutor.Size = new System.Drawing.Size(120, 45);
            this.btnFiltroAutor.TabIndex = 12;
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
            this.btnReiniciar.Location = new System.Drawing.Point(740, 50);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(120, 45);
            this.btnReiniciar.TabIndex = 14;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnFiltroStock
            // 
            this.btnFiltroStock.BorderRadius = 10;
            this.btnFiltroStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltroStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltroStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltroStock.FillColor = System.Drawing.Color.Coral;
            this.btnFiltroStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFiltroStock.ForeColor = System.Drawing.Color.White;
            this.btnFiltroStock.Location = new System.Drawing.Point(480, 50);
            this.btnFiltroStock.Name = "btnFiltroStock";
            this.btnFiltroStock.Size = new System.Drawing.Size(120, 45);
            this.btnFiltroStock.TabIndex = 15;
            this.btnFiltroStock.Text = "Stock";
            this.btnFiltroStock.Click += new System.EventHandler(this.btnFiltroStock_Click);
            // 
            // tablaLibros
            // 
            this.tablaLibros.AllowUserToAddRows = false;
            this.tablaLibros.AllowUserToDeleteRows = false;
            this.tablaLibros.AllowUserToResizeColumns = false;
            this.tablaLibros.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NumSerie,
            this.Marca,
            this.Modelo,
            this.Localizacion,
            this.Estado,
            this.btnReservar});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaLibros.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablaLibros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaLibros.Location = new System.Drawing.Point(90, 228);
            this.tablaLibros.MultiSelect = false;
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.ReadOnly = true;
            this.tablaLibros.RowHeadersVisible = false;
            this.tablaLibros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaLibros.Size = new System.Drawing.Size(770, 374);
            this.tablaLibros.TabIndex = 16;
            this.tablaLibros.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.tablaLibros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.tablaLibros.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaLibros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaLibros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaLibros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaLibros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaLibros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaLibros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tablaLibros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaLibros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaLibros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaLibros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaLibros.ThemeStyle.HeaderStyle.Height = 23;
            this.tablaLibros.ThemeStyle.ReadOnly = true;
            this.tablaLibros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.tablaLibros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaLibros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaLibros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablaLibros.ThemeStyle.RowsStyle.Height = 22;
            this.tablaLibros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.tablaLibros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaLibros_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ISBN";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NumSerie
            // 
            this.NumSerie.HeaderText = "Titulo";
            this.NumSerie.Name = "NumSerie";
            this.NumSerie.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Genero";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Autor";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Localizacion
            // 
            this.Localizacion.HeaderText = "Precio";
            this.Localizacion.Name = "Localizacion";
            this.Localizacion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Stock";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnReservar
            // 
            this.btnReservar.HeaderText = "Modificar";
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.Coral;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(740, 622);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 45);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // VistaLibrosGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 691);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tablaLibros);
            this.Controls.Add(this.btnFiltroStock);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnFiltroAutor);
            this.Controls.Add(this.btnFiltroPrecio);
            this.Controls.Add(this.btnFiltroGenero);
            this.Controls.Add(this.txtBuscar);
            this.Name = "VistaLibrosGerente";
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button btnFiltroGenero;
        private Guna.UI2.WinForms.Guna2Button btnFiltroPrecio;
        private Guna.UI2.WinForms.Guna2Button btnFiltroAutor;
        private Guna.UI2.WinForms.Guna2Button btnReiniciar;
        private Guna.UI2.WinForms.Guna2Button btnFiltroStock;
        private Guna.UI2.WinForms.Guna2DataGridView tablaLibros;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnReservar;
    }
}