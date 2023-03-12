using Datos.Controllers;
using Datos.Models;
using Presentacion.Views.VistasGerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views.VistasVendedor
{
    public partial class VistaLibrosVendedor : Form
    {
        public VistaLibrosVendedor()
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
                tablaLibros.Rows.Add(libro.isbn, libro.titulo, genero.nombre, libro.autor, libro.precio, libro.stock, "Vender");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Libro> libros = new LibrosController().ObtenerLibrosPorBusqueda(txtBuscar.Text);
            LimpiarTabla();
            CargarTabla(libros);
        }

        private void tablaLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {            
            
                DataGridViewRow fila = tablaLibros.Rows[e.RowIndex];
                string isbn = fila.Cells[0].Value.ToString();
                string stock = fila.Cells[5].Value.ToString();

                if (stock.Equals("0"))
                {
                    MostrarMensajeError("No hay stock de este libro");
                    return;
                }

                Libro libro = new LibrosController().ObtenerLibro(isbn);
                Usuario usuario = new UsuarioController().ObtenerUsuario(Login.instanciaLogin.correo);
                Venta venta = new Venta()
                {
                    idUsuario = usuario.idUsuario,
                    isbn = isbn
                };
                bool exito = new VentaController().InsertarVenta(venta);
                if (!exito)
                {
                    MostrarMensajeError("Error al realizar la venta del libro");                    
                    return;
                }
                MostrarMensajeInfo("Venta realizada con exito");
                libro.stock--;            
                new LibrosController().ModificarLibro(libro);
                LimpiarTabla();
                CargarTabla(null);

            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
            CargarTabla(null);
        }

        private void btnFiltroGenero_Click(object sender, EventArgs e)
        {
            Filtrar filtro = new Filtrar();
            FiltroGeneros popup = new FiltroGeneros(filtro);
            popup.ShowDialog();

            List<string> autoresSeleccionados = filtro.listaParaFiltrar;

            if (autoresSeleccionados.Count() > 0)
            {
                List<Libro> listaLibrosFiltrados = new LibrosController().ObtenerLibrosPorGenero(autoresSeleccionados);
                LimpiarTabla();
                CargarTabla(listaLibrosFiltrados);
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
                LimpiarTabla();
                CargarTabla(listaLibrosFiltrados);
            }
        }

        private void tablaLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

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
