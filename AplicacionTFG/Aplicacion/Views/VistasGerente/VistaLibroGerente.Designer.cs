﻿namespace Presentacion.Views.VistasGerente
{
    partial class VistaLibroGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaLibroGerente));
            this.panelFormulario = new Guna.UI2.WinForms.Guna2Panel();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelStock = new Presentacion.Controllers.LabelPropio();
            this.numStock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelPrecio = new Presentacion.Controllers.LabelPropio();
            this.labelAutor = new Presentacion.Controllers.LabelPropio();
            this.labelISBN = new Presentacion.Controllers.LabelPropio();
            this.labelTitulo = new Presentacion.Controllers.LabelPropio();
            this.numPrecio = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.labelGenero = new Presentacion.Controllers.LabelPropio();
            this.txtAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.botonModificar = new Presentacion.Controllers.BotonPropio(this.components);
            this.btnBorrar = new Presentacion.Controllers.BotonPropio(this.components);
            this.btnCancelar = new Presentacion.Controllers.BotonPropio(this.components);
            this.resultado = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulario
            // 
            this.panelFormulario.Controls.Add(this.txtISBN);
            this.panelFormulario.Controls.Add(this.labelStock);
            this.panelFormulario.Controls.Add(this.numStock);
            this.panelFormulario.Controls.Add(this.labelPrecio);
            this.panelFormulario.Controls.Add(this.labelAutor);
            this.panelFormulario.Controls.Add(this.labelISBN);
            this.panelFormulario.Controls.Add(this.labelTitulo);
            this.panelFormulario.Controls.Add(this.numPrecio);
            this.panelFormulario.Controls.Add(this.labelGenero);
            this.panelFormulario.Controls.Add(this.txtAutor);
            this.panelFormulario.Controls.Add(this.txtTitulo);
            this.panelFormulario.Controls.Add(this.cbGenero);
            this.panelFormulario.Location = new System.Drawing.Point(224, 61);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(356, 293);
            this.panelFormulario.TabIndex = 0;
            // 
            // txtISBN
            // 
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.Enabled = false;
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Location = new System.Drawing.Point(148, 25);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.PlaceholderText = "";
            this.txtISBN.SelectedText = "";
            this.txtISBN.Size = new System.Drawing.Size(200, 36);
            this.txtISBN.TabIndex = 15;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(56, 245);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 17);
            this.labelStock.TabIndex = 14;
            this.labelStock.Text = "Stock";
            // 
            // numStock
            // 
            this.numStock.BackColor = System.Drawing.Color.Transparent;
            this.numStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numStock.Location = new System.Drawing.Point(148, 235);
            this.numStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(200, 36);
            this.numStock.TabIndex = 6;
            this.numStock.UpDownButtonFillColor = System.Drawing.Color.Coral;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(56, 202);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(46, 17);
            this.labelPrecio.TabIndex = 13;
            this.labelPrecio.Text = "Precio";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(56, 160);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(43, 17);
            this.labelAutor.TabIndex = 12;
            this.labelAutor.Text = "Autor";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(56, 36);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(37, 17);
            this.labelISBN.TabIndex = 9;
            this.labelISBN.Text = "ISBN";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(56, 118);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(45, 17);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Título";
            // 
            // numPrecio
            // 
            this.numPrecio.BackColor = System.Drawing.Color.Transparent;
            this.numPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPrecio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrecio.Location = new System.Drawing.Point(148, 193);
            this.numPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(200, 36);
            this.numPrecio.TabIndex = 4;
            this.numPrecio.UpDownButtonFillColor = System.Drawing.Color.Coral;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(56, 77);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(52, 17);
            this.labelGenero.TabIndex = 10;
            this.labelGenero.Text = "Género";
            // 
            // txtAutor
            // 
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.DefaultText = "";
            this.txtAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAutor.Location = new System.Drawing.Point(148, 151);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.PlaceholderText = "";
            this.txtAutor.SelectedText = "";
            this.txtAutor.Size = new System.Drawing.Size(200, 36);
            this.txtAutor.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitulo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitulo.Location = new System.Drawing.Point(148, 109);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(200, 36);
            this.txtTitulo.TabIndex = 2;
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.Transparent;
            this.cbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGenero.ItemHeight = 30;
            this.cbGenero.Location = new System.Drawing.Point(148, 67);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(200, 36);
            this.cbGenero.TabIndex = 1;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // botonModificar
            // 
            this.botonModificar.BackColor = System.Drawing.Color.LimeGreen;
            this.botonModificar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.botonModificar.BorderColor = System.Drawing.Color.Coral;
            this.botonModificar.BorderRadius = 0;
            this.botonModificar.BorderSize = 0;
            this.botonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonModificar.ForeColor = System.Drawing.Color.White;
            this.botonModificar.Location = new System.Drawing.Point(536, 383);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(180, 45);
            this.botonModificar.TabIndex = 4;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.TextColor = System.Drawing.Color.White;
            this.botonModificar.UseVisualStyleBackColor = false;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Brown;
            this.btnBorrar.BackgroundColor = System.Drawing.Color.Brown;
            this.btnBorrar.BorderColor = System.Drawing.Color.Coral;
            this.btnBorrar.BorderRadius = 0;
            this.btnBorrar.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(334, 383);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(180, 45);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextColor = System.Drawing.Color.White;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Coral;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Coral;
            this.btnCancelar.BorderColor = System.Drawing.Color.Coral;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(119, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // resultado
            // 
            this.resultado.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.resultado.Caption = null;
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.resultado.Parent = null;
            this.resultado.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.resultado.Text = null;
            // 
            // VistaLibroGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaLibroGerente";
            this.Text = "VistaLibroNuevo";
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelFormulario;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox cbGenero;
        private Guna.UI2.WinForms.Guna2NumericUpDown numStock;
        private Controllers.LabelPropio labelTitulo;
        private Controllers.LabelPropio labelGenero;
        private Controllers.LabelPropio labelISBN;
        private Controllers.LabelPropio labelStock;
        private Controllers.LabelPropio labelPrecio;
        private Controllers.LabelPropio labelAutor;
        private Controllers.BotonPropio btnCancelar;
        private Controllers.BotonPropio btnBorrar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private Controllers.BotonPropio botonModificar;
        private Guna.UI2.WinForms.Guna2MessageDialog resultado;
    }
}