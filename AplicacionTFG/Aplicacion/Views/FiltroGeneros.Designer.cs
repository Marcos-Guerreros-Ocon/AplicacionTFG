namespace Presentacion.Views
{
    partial class FiltroGeneros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaFiltroGeneros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCerrar = new Presentacion.Controllers.BotonPropio(this.components);
            this.btnFiltrar = new Presentacion.Controllers.BotonPropio(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFiltroGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaFiltroGeneros
            // 
            this.tablaFiltroGeneros.AllowUserToAddRows = false;
            this.tablaFiltroGeneros.AllowUserToDeleteRows = false;
            this.tablaFiltroGeneros.AllowUserToResizeColumns = false;
            this.tablaFiltroGeneros.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tablaFiltroGeneros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaFiltroGeneros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaFiltroGeneros.ColumnHeadersHeight = 15;
            this.tablaFiltroGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaFiltroGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Género,
            this.Filtrar});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaFiltroGeneros.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablaFiltroGeneros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaFiltroGeneros.Location = new System.Drawing.Point(102, 61);
            this.tablaFiltroGeneros.Name = "tablaFiltroGeneros";
            this.tablaFiltroGeneros.RowHeadersVisible = false;
            this.tablaFiltroGeneros.Size = new System.Drawing.Size(304, 302);
            this.tablaFiltroGeneros.TabIndex = 3;
            this.tablaFiltroGeneros.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.tablaFiltroGeneros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.tablaFiltroGeneros.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaFiltroGeneros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaFiltroGeneros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaFiltroGeneros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaFiltroGeneros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaFiltroGeneros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaFiltroGeneros.ThemeStyle.HeaderStyle.Height = 15;
            this.tablaFiltroGeneros.ThemeStyle.ReadOnly = false;
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.Height = 22;
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.tablaFiltroGeneros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Género
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Género.DefaultCellStyle = dataGridViewCellStyle11;
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            this.Género.ReadOnly = true;
            // 
            // Filtrar
            // 
            this.Filtrar.HeaderText = "Filtrar";
            this.Filtrar.Name = "Filtrar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.Brown;
            this.btnCerrar.BorderColor = System.Drawing.Color.Coral;
            this.btnCerrar.BorderRadius = 0;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(102, 391);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 33);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Coral;
            this.btnFiltrar.BackgroundColor = System.Drawing.Color.Coral;
            this.btnFiltrar.BorderColor = System.Drawing.Color.Coral;
            this.btnFiltrar.BorderRadius = 0;
            this.btnFiltrar.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(288, 391);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(118, 33);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextColor = System.Drawing.Color.White;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FiltroGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tablaFiltroGeneros);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FiltroGeneros";
            this.ShowIcon = false;
            this.Text = "FiltroGeneros";
            ((System.ComponentModel.ISupportInitialize)(this.tablaFiltroGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tablaFiltroGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Filtrar;
        private Controllers.BotonPropio btnCerrar;
        private Controllers.BotonPropio btnFiltrar;
    }
}