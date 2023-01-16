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

        private void btnAgregar_Click(object sender, EventArgs e)
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

            bool exito = new LibrosController().InsertarLibro(libro);
            if (!exito)
            {
                MessageBox.Show("Error al insertar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Libro insertado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
