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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace Presentacion.Views.VistasVendedor
{
    public partial class VistaCuentaVendedor : Form
    {
        public VistaCuentaVendedor()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Usuario vendedor = new UsuarioController().ObtenerUsuario(Login.instanciaLogin.correo);
            txtCorreo.Text = vendedor.correo;
            txtNombre.Text = vendedor.nombre;
            txtApellidos.Text = vendedor.apellidos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario vendedor = new UsuarioController().ObtenerUsuario(Login.instanciaLogin.correo);

            if (!ComprobarCampos())
            {
                return;
            }

            Usuario usuario = new UsuarioController().ObtenerUsuario(txtCorreo.Text.Trim());
            if (usuario!=null && !txtCorreo.Text.Equals(vendedor.correo))
            {
                MostrarMensajeError("El correo ya esta en uso.");
                return;
            }

            string correo = txtCorreo.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string password = vendedor.contrasenia;
            if (!txtContrasenia.Text.Trim().Equals(""))
            {
                password = CifrarContraseña(txtContrasenia.Text.Trim());
            }

            Usuario vendedorModificado = new Usuario
            {
                idUsuario = vendedor.idUsuario,
                correo = txtCorreo.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                apellidos = txtApellidos.Text.Trim(),
                contrasenia = password
            };

            bool exito = new UsuarioController().ModificarUsuario(vendedor.idUsuario, vendedorModificado);

            if (!exito)
            {
                MostrarMensajeError("Error al modificar los datos");
                return;
            }
            MostrarMensajeInfo("Los datos han sido modifiaco con exito");
            Login.instanciaLogin.correo = txtCorreo.Text.Trim();

        }

        private bool ComprobarCampos()
        {
            if (!CampoTextoCorrecto(txtCorreo.Text))
            {
                MostrarMensajeError("Campo correo vacio");
                return false;
            }
            if (!CampoCorreoCorrecto(txtCorreo.Text))
            {
                MostrarMensajeError("El correo debe ser del dominio @correo.com");
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
            if (CampoTextoCorrecto(txtContrasenia.Text) && !txtContrasenia.Text.Equals(txtConfirmarContraseña.Text))
            {
                MostrarMensajeError("Las contraseña no coincide");
                return false;                
            }
            return true;
        }

        private bool CampoCorreoCorrecto(string text)
        {
            Regex expresion = new Regex("\\w+@correo.com");
            return expresion.IsMatch(text.Trim());
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
