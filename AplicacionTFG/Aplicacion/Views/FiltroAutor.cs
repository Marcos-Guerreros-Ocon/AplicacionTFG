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

namespace Presentacion.Views
{
    public partial class FiltroAutor : Form
    {
        public Filtrar filtro { get; set; }
        public FiltroAutor(Filtrar filtro)
        {
            InitializeComponent();
            cargarTabla();
            this.filtro = filtro;
        }

        private void cargarTabla()
        {
            List<string> autores = new LibrosController().ObtenerAutores();           

            foreach (string autor in autores)
            {
                tablaFiltroAutores.Rows.Add(autor);                
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<string> generos = new List<string>();

            foreach (DataGridViewRow fila in tablaFiltroAutores.Rows)
            {
                if (fila.Cells[1].Value != null)
                {
                    String categoria = fila.Cells[0].Value.ToString();
                    generos.Add(categoria);
                }
            }
            filtro.listaParaFiltrar = generos;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
