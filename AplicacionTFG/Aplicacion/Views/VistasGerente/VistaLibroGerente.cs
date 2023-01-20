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
                MessageBox.Show("Error al borrar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Libro borrado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarMensajeInfo(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
