using Datos.Controllers;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaVendedorNuevo : Form
    {
        public VistaVendedorNuevo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ComprobarCampos())
            {
                return;
            }

            string contraseña =CifrarContraseña(txtContrasenia.Text.Trim());
            Usuario usuario = new Usuario()
            {
                nombre = txtNombre.Text.Trim(),
                apellidos = txtApellidos.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                contrasenia = contraseña
            };

            bool exito = new UsuarioController().InsertarUsuario(usuario);
            if (!exito)
            {
                MostarMensajeError("No se ha podido crear el usuario");
                return;
            }

            MostarMensajeInfo("Usuario creado con exito");

        }
        private bool ComprobarCampos()
        {
            if (!CampoTextoCorrecto(txtCorreo.Text))
            {
                MostarMensajeError("Campo correo vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtNombre.Text))
            {
                MostarMensajeError("Campo nombre vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtApellidos.Text))
            {
                MostarMensajeError("Campo Apellidos vacio");
                return false;
            }
            if (!CampoTextoCorrecto(txtContrasenia.Text))
            {
                MostarMensajeError("Campo contraseña vacio");
                return false;
            }
            return true;
        }

        private bool CampoTextoCorrecto(string texto)
        {
            return !texto.Trim().Equals("");
        }

        private void MostarMensajeError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostarMensajeInfo(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string CifrarContraseña(string contraseña)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(contraseña));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
