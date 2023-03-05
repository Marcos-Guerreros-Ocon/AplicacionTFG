using Datos.Controllers;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaLibroNuevo : Form
    {
        public VistaLibroNuevo()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            List<Genero> generos = new GeneroController().ObtenerGeneros();
            foreach (Genero genero in generos)
            {
                cbGenero.Items.Add(genero.nombre);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool comprobarCampos()
        {
            if (!CampoTextoCorrecto(this.txtISBN.Text))
            {
                MostrarMensajeInfo("El campo ISBN no puede estar vacio");
                return false;
            }

            if (!CampoTextoCorrecto(this.txtTitulo.Text))
            {
                MostrarMensajeInfo("El campo Título no puede estar vacio");
                return false;
            }
            if (!CampoTextoCorrecto(this.cbGenero.SelectedItem.ToString()))
            {
                MostrarMensajeInfo("El campo Género no puede estar vacio");
                return false;
            }

            if (!CampoNumeroCorrecto((int)this.numStock.Value))
            {
                MostrarMensajeInfo("El campo Stock no puede ser inferior a 0");
                return false;
            }

            if (!CampoNumeroCorrecto((int)this.numPrecio.Value))
            {
                MostrarMensajeInfo("El campo Precio no puede ser inferior a 0");
                return false;
            }
            if (!CampoTextoCorrecto(this.txtAutor.Text))
            {
                MostrarMensajeInfo("El campo Autor no puede estar vacio");
                return false;
            }

            return true;

        }
        private bool CampoTextoCorrecto(string texto)
        {
            return !texto.Trim().Equals("");
        }

        private bool CampoNumeroCorrecto(int numero)
        {
            return numero >= 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!this.comprobarCampos())
            {
                return;
            }
            Genero genero = new GeneroController().ObtenerGenero(cbGenero.SelectedItem.ToString());

           

            Libro libro = new Libro()
            {
                isbn = txtISBN.Text,
                idGenero = genero.idGenero,
                titulo = txtTitulo.Text,
                autor = txtAutor.Text,
                precio = (int)numPrecio.Value,
                stock = (int)numStock.Value
            };

            bool exito = new LibrosController().InsertarLibro(libro);
            if (!exito)
            {
                this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                this.resultado.Caption = "Error";
                this.resultado.Text = "Error al insertar el libro";
                this.resultado.Show();

                this.Close();
                return;
            }
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.resultado.Caption = "Info";
            this.resultado.Text = "Libro insertado con exito";
            this.resultado.Show();


            this.Close();

        }


        private void MostrarMensajeError(string msg)
        {
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.resultado.Caption = "Error";
            this.resultado.Text = msg;
            this.resultado.Show();
        }
        private void MostrarMensajeInfo(string msg)
        {
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.resultado.Caption = "Info";
            this.resultado.Text = msg;
            this.resultado.Show();
        }
    }
}
