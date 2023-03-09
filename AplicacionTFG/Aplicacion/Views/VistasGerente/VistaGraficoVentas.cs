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
        private String estiloGrafico;
        public VistaGraficoVentas()
        {
            InitializeComponent();
            cargarGrafico();
            estiloGrafico = "Pie";

         
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
         
            
        }

        private void botonRedondeadoPropio1_Click(object sender, EventArgs e)
        {
            if (estiloGrafico.Equals("Pie"))
            {
                graficoVendedores.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                estiloGrafico = "Columna";
                btnCambiarGrafico.Text = "Gráfico Pie";

            }
            else
            {
                graficoVendedores.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                estiloGrafico = "Pie";
                btnCambiarGrafico.Text = "Gráfico Columna";
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
