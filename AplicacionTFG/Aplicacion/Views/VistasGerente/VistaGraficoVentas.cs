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
            
        }

        private void botonRedondeadoPropio1_Click(object sender, EventArgs e)
        {
            graficoVendedores.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
    }
}
