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
        public VistaVentasGerente()
        {
            InitializeComponent();
            CargarTabla();

        }

        private void CargarTabla()
        {
            List<Venta>ventas = new VentaController().ObtenerVentas();
            Usuario usuario;
            Libro libro;
            foreach (Venta venta in ventas)
            {
                usuario = new UsuarioController().ObtenerUsuario(venta.idUsuario);
                libro = new LibrosController().ObtenerLibro(venta.isbn);
                tablaVentas.Rows.Add(libro.isbn,libro.titulo,libro.autor,usuario.nombre,usuario.apellidos,usuario.correo);
            }
        }

        private void btnVistaGrafico_Click(object sender, EventArgs e)
        {
            new VistaGraficoVentas().ShowDialog();
     
        }
    }
}
