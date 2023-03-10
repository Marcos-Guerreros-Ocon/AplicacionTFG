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
    public partial class VistaGraficoVentas : Form
    {

        public VistaGraficoVentas()
        {
            InitializeComponent();
            cargarGrafico();         
        }

        private void cargarGrafico()
        {
            List<Usuario> vendedores = new UsuarioController().ObtenerVendedores();
            List<Venta> ventas;
            foreach (Usuario vendedor in vendedores)
            {
                ventas = new VentaController().ObtenerVentasDelVendedor(vendedor.idUsuario);

                graficoVendedores.ChartAreas[0].AxisX.MajorGrid.Enabled= false;
                graficoVendedores.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                graficoVendedores.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                graficoVendedores.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                graficoVendedores.BackColor = Color.White;
                graficoVendedores.Series["Ventas"].IsValueShownAsLabel= true;
                graficoVendedores.Series["Ventas"].Points.AddXY(vendedor.nombre + " " + vendedor.apellidos, ventas.Count());
            }

            List<Genero> generos = new GeneroController().ObtenerGeneros();
            foreach (Genero genero in generos) {
                ventas = new VentaController().ObtenerVentasGenero(genero.idGenero);
                graficoGeneros.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                graficoGeneros.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                graficoGeneros.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                graficoGeneros.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                graficoGeneros.BackColor = Color.White;
                graficoGeneros.Series["Ventas"].IsValueShownAsLabel = true;
                graficoGeneros.Series["Ventas"].Points.AddXY(genero.nombre, ventas.Count());
            }
            
        }
    }
}
