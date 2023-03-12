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

namespace Presentacion.Views.VistasVendedor
{
    public partial class VistaVentasVendedor : Form
    {
        public VistaVentasVendedor()
        {
            InitializeComponent();
            CargarTabla(null);
            CargarGrafico();
        }
        public void CargarTabla(List<Venta> ventas)
        {
            if (ventas == null)
            {
                ventas = new VentaController().ObtenerVentas();
            }

            Usuario usuario;

            tablaVentas.Rows.Clear();
            Libro libro;
            Genero genero;
            foreach (Venta venta in ventas)
            {
                usuario = new UsuarioController().ObtenerUsuario(venta.idUsuario);

                if (usuario.correo.Equals(Login.instanciaLogin.correo))
                {
                    libro = new LibrosController().ObtenerLibro(venta.isbn);
                    genero = new GeneroController().ObtenerGenero(libro.idGenero);
                    tablaVentas.Rows.Add(libro.isbn, libro.titulo, libro.autor, genero.nombre, libro.precio + "€");
                }

            }
        }

        private void CargarGrafico()
        {
            Usuario vendedor = new UsuarioController().ObtenerUsuario(Login.instanciaLogin.correo);
            List<Venta> test = new VentaController().ObtenerVentasDelVendedor(vendedor.idUsuario);

            Dictionary<string, int> ventasGeneros = new Dictionary<string, int>();

            Libro libro;
            Genero genero;
            foreach (Venta venta in test)
            {
                libro = new LibrosController().ObtenerLibro(venta.isbn);
                genero = new GeneroController().ObtenerGenero(libro.idGenero);
                if (!ventasGeneros.ContainsKey(genero.nombre))
                {
                    ventasGeneros[genero.nombre] = 0;
                }
                ventasGeneros[genero.nombre]++;
            }

            List<string> keyList = new List<string>(ventasGeneros.Keys);
            foreach (string key in keyList)
            {
               
                graficoVentas.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                graficoVentas.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                graficoVentas.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                graficoVentas.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                graficoVentas.BackColor = Color.White;
                graficoVentas.Series["Ventas"].IsValueShownAsLabel = true;
                graficoVentas.Series["Ventas"].Points.AddXY(key, ventasGeneros[key]);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            List<Venta> ventas = new VentaController().ObtenerVentaPorBusquedaVendedor(txtBuscar.Text);

            CargarTabla(ventas);
        }
    }
}
