using Datos.Controllers;
using Datos.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaLibrosGerente : Form
    {
        public VistaLibrosGerente()
        {
            InitializeComponent();
            CargarTabla(null);
        }

        public void LimpiarTabla()
        {
            tablaLibros.Rows.Clear();
        }
        public void CargarTabla(List<Libro> listaFiltrada)
        {
            List<Libro> libros;
            if (listaFiltrada is null)
            {
                libros = new LibrosController().ObtenerLibros();
            }
            else
            {
                libros = listaFiltrada;
            }

            foreach (Libro libro in libros)
            {
                Genero genero = new GeneroController().ObtenerGenero(libro.idGenero);
                tablaLibros.Rows.Add(libro.isbn, libro.titulo, genero.nombre, libro.autor, libro.precio, libro.stock, "Modificar");
            }
        }
        private void RecargarTabla(List<Libro> lista)
        {
            LimpiarTabla();
            CargarTabla(lista);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VistaLibroNuevo popup = new VistaLibroNuevo();
            popup.ShowDialog();
            RecargarTabla(null);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Libro> libros = new LibrosController().ObtenerLibrosPorBusqueda(txtBuscar.Text);
            RecargarTabla(libros);
        }
        private void tablaLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                DataGridViewRow fila = tablaLibros.Rows[e.RowIndex];
                string isbn = fila.Cells[0].Value.ToString();
                VistaLibroGerente vistaLibroGerente = new VistaLibroGerente(isbn);
                vistaLibroGerente.ShowDialog();
                RecargarTabla(null);
            }

        }    
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            RecargarTabla(null);
        }

        private void btnFiltroGenero_Click(object sender, EventArgs e)
        {
            Filtrar filtro = new Filtrar();
            FiltroGeneros popup = new FiltroGeneros(filtro);
            popup.ShowDialog();

            List<string> generosSelectionados = filtro.listaParaFiltrar;
            
            if (generosSelectionados.Count() > 0)
            {
                List<Libro> listaLibrosFiltrados = new LibrosController().ObtenerLibrosPorGenero(generosSelectionados);
                RecargarTabla(listaLibrosFiltrados);
            }
        }

        private void btnFiltroAutor_Click(object sender, EventArgs e)
        {
            Filtrar filtro = new Filtrar();
            FiltroAutor popup = new FiltroAutor(filtro);
            popup.ShowDialog();

            List<string> autoresSeleccionados = filtro.listaParaFiltrar;

            if (autoresSeleccionados.Count() > 0)
            {
                List<Libro> listaLibrosFiltrados = new LibrosController().ObtenerLibrosPorAutor(autoresSeleccionados);
                RecargarTabla(listaLibrosFiltrados);
            }
        }

        private void btnFiltroPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltroStock_Click(object sender, EventArgs e)
        {

        }
    }
}
