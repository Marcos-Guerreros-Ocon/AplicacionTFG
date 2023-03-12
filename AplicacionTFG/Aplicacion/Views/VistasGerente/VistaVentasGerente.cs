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
    public partial class VistaVentasGerente : Form
    {

        private bool graficoActivo;
        private VistaGraficoVentas ventas;
        public VistaVentasGerente()
        {
            InitializeComponent();
            CargarTabla(null);
            graficoActivo = false;
            ventas = new VistaGraficoVentas();

        }

        public void CargarTabla(List<Venta>ventas)
        {
            if (ventas==null)
            {
                ventas = new VentaController().ObtenerVentas();
            }     
          
            Usuario usuario;

            tablaVentas.Rows.Clear();
            Libro libro;
            foreach (Venta venta in ventas)
            {
                usuario = new UsuarioController().ObtenerUsuario(venta.idUsuario);
                libro = new LibrosController().ObtenerLibro(venta.isbn);
                tablaVentas.Rows.Add(libro.isbn, libro.titulo, libro.autor, usuario.nombre, usuario.apellidos, usuario.correo);
            }
        }

        private void btnVistaGrafico_Click(object sender, EventArgs e)
        {

            if (graficoActivo)
            {
                ventas.Close();
                flowLayoutPanel1.Visible = false;
                graficoActivo = false;
                btnVistaGrafico.Text = "Vista Gráfico";
            }
            else
            {
                ventas = new VistaGraficoVentas();
                ventas.TopLevel = false;
                flowLayoutPanel1.Controls.Add(ventas);
                flowLayoutPanel1.Visible = true;
                ventas.BringToFront();
                ventas.Show();
                graficoActivo = true;
                btnVistaGrafico.Text = "Vista Tabla";

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Venta> ventas = new VentaController().ObtenerVentaPorBusquedaAdministrador(txtBuscar.Text);

            CargarTabla(ventas);

        }
    }
}
