using Datos.Controllers;
using Datos.Models;
using System;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaVendedorGerente : Form
    {
        public VistaVendedorGerente(int id)
        {
            InitializeComponent();
            CargarDatos(id);
        }

        private void CargarDatos(int id)
        {
            Usuario usuario = new UsuarioController().ObtenerUsuario(id);
            txtIdUsuario.Text = usuario.idUsuario.ToString();
            txtCorreo.Text = usuario.correo;
            txtNombre.Text = usuario.nombre;
            txtApellidos.Text = usuario.apellidos;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool exito = new UsuarioController().BorrarUsuario(Int32.Parse(txtIdUsuario.Text));
            if (!exito)
            {
                MostrarMensajeError("Error al borrar el vendedor");
                return;
            }
            MostrarMensajeInfo("Vendedor borrado con exito");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.ComprobarCampos())
            {
                return;
            }
            Usuario usuario = new Usuario()
            {
                idUsuario = Int32.Parse(txtIdUsuario.Text),
                nombre = txtNombre.Text,
                apellidos = txtApellidos.Text,
                correo = txtCorreo.Text
            };

            bool exito = new UsuarioController().ModificarUsuario(usuario);
            if (!exito)
            {
                MostrarMensajeError("Error al modificar los datos del vendedor");
                return;
            }
            MostrarMensajeInfo("Los datos del vendedor se han modificado correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarMensajeError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarMensajeInfo(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ComprobarCampos()
        {
            if (!CampoTextoCorrecto(txtCorreo.Text))
            {
                MostrarMensajeError("Campo correo vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtNombre.Text))
            {
                MostrarMensajeError("Campo nombre vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtApellidos.Text))
            {
                MostrarMensajeError("Campo Apellidos vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtContrasenia.Text))
            {
                MostrarMensajeError("Campo contraseña vacio");
                return false;
            }
            return true;
        }

        private bool CampoTextoCorrecto(string texto)
        {
            return !texto.Trim().Equals("");
        }
    }
}
