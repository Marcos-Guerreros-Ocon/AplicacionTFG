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
    public partial class VistaGenerosGerente : Form
    {
        public VistaGenerosGerente()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            List<Genero> generos = new GeneroController().ObtenerGeneros();
            foreach (Genero genero in generos)
            {
                tablaGeneros.Rows.Add(genero.idGenero, genero.nombre, "Borrar");
            }
        }
        private void Limpiartabla()
        {
            tablaGeneros.Rows.Clear();
        }
        private void RecargarTabla()
        {
            Limpiartabla();
            CargarTabla();
        }
        private void AgregarGenero(string text)
        {
            Genero genero = new Genero()
            {
                nombre = text
            };
            bool exito = new GeneroController().InsertarGenero(genero);
            if (!exito)
            {
                MessageBox.Show("Error al crear el género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Género creado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BorrarGenero(int id)
        {
            bool exito = new GeneroController().BorrarGenero(id);
            if (!exito)
            {
                MessageBox.Show("Error al borrar el género", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Género borrado con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarGenero(this.txtNombreGenero.Text);
            RecargarTabla();
        }
        private void tablaGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                DataGridViewRow fila = tablaGeneros.Rows[e.RowIndex];
                int idGenero = (int)fila.Cells[0].Value;
                BorrarGenero(idGenero);
                RecargarTabla();
            }
        }
    }
}
