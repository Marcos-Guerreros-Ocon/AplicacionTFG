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
                MostrarMensajeError("No se ha podido crear el usuario");
                this.Close();
                return;
            }

            MostrarMensajeInfo("Usuario creado con exito");

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

        private void MostrarMensajeError(string msg)
        {
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.resultado.Caption = "Error";
            this.resultado.Text = msg;
            this.resultado.Show();
        }
        private void MostrarMensajeInfo(string msg)
        {
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.resultado.Caption = "Info";
            this.resultado.Text = msg;
            this.resultado.Show();
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
