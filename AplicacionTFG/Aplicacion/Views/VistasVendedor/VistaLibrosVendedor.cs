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
                    MessageBox.Show("No hay stock de este libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Error al realizar la venta del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Venta realizada con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
