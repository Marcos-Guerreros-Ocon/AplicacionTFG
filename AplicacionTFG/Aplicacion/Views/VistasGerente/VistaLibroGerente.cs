using Datos.Controllers;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaLibroGerente : Form
    {
        public VistaLibroGerente(string isbn)
        {
            InitializeComponent();
            CargarComboBox();
            CargarLibro(isbn);
        }

        private void CargarComboBox()
        {
            List<Genero> generos = new GeneroController().ObtenerGeneros();
            foreach (Genero genero in generos)
            {
                cbGenero.Items.Add(genero.nombre);
            }
        }

        private void CargarLibro(string isbn)
        {
            Libro libro = new LibrosController().ObtenerLibro(isbn);
            Genero genero = new GeneroController().ObtenerGenero(libro.idGenero);
            txtISBN.Text = isbn;
            txtTitulo.Text = libro.titulo;
            txtAutor.Text = libro.autor;
            numPrecio.Value = libro.precio;
            numStock.Value = libro.stock;
            string nombre;
            for (int i = 0; i < cbGenero.Items.Count; i++)
            {
                cbGenero.SelectedIndex = i;
                nombre = cbGenero.SelectedItem.ToString();
                if (nombre.Equals(genero.nombre))
                {
                    break;
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool exito = new LibrosController().BorrarLibro(txtISBN.Text);
            if (!exito)
            {
                MostrarMensajeError("Error al borrar el libro");
                this.Close();
                return;
            }

            MostrarMensajeInfo("Libro borrado con exito");
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
        private void botonModificar_Click(object sender, EventArgs e)
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
            bool exito = new LibrosController().ModificarLibro(libro);
            if (!exito)
            {
                MostrarMensajeError("Error al modificar el libro");
                return;
            }
            MostrarMensajeInfo("Libro modificado con exito");

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
