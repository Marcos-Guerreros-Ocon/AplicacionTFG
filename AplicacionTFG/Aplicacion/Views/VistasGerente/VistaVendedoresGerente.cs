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
    public partial class VistaVendedoresGerente : Form
    {
        public VistaVendedoresGerente()
        {
            InitializeComponent();
            CargarTabla(null);
        }

        
        private void CargarTabla(List<Usuario> listaFiltrada)
        {
            List<Usuario> vendedores;
            if (listaFiltrada == null)
            {
                vendedores = new UsuarioController().ObtenerVendedores();
            }
            else
            {
                vendedores = listaFiltrada;
            }

            foreach (Usuario usuario in vendedores)
            {
                tablaVendedores.Rows.Add(usuario.idUsuario, usuario.nombre,usuario.apellidos, usuario.correo, "Modificar");
            }
        }
        private void LimpiarTabla()
        {
            tablaVendedores.Rows.Clear();
        }
        private void RecargarTabla(List<Usuario> listaFiltrada)
        {
            LimpiarTabla();
            CargarTabla(listaFiltrada);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Usuario> vendedores = new UsuarioController().ObtenerVendedoresBusqueda(txtBuscar.Text.Trim());
            RecargarTabla(vendedores);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VistaVendedorNuevo vistaVendedorNuevo = new VistaVendedorNuevo();
            vistaVendedorNuevo.ShowDialog();
            RecargarTabla(null);
        }

        private void tablaVendedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                DataGridViewRow fila = tablaVendedores.Rows[e.RowIndex];
                int id= (int)fila.Cells[0].Value;
                VistaVendedorGerente vistaVendedorGerente = new VistaVendedorGerente(id);
                vistaVendedorGerente.ShowDialog();
                RecargarTabla(null);
            }
        }
    }
}
