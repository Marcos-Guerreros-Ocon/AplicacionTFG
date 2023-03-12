
using Datos.Controllers;
using Datos.Models;
using Presentacion.Views.VistasGerente;
using Presentacion.Views.VistasVendedor;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentacion.Views
{
    public partial class Login : Form
    {
        public static Login instanciaLogin { get; set; }
        public string correo { get; set; }
        public Login()
        {
            InitializeComponent();
            instanciaLogin = this;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        
            string correo = txtCorreo.Text.Trim();
            string contraseña = txtPassword.Text.Trim();
            Regex expresion = new Regex("\\w+@correo.com");

            if (correo == "")
            {
                MostrarMensajeError("El campo correo esta vacio");
                return;
            }

            if (contraseña == "")
            {
                MostrarMensajeError("El campo contraseña vacio");
                return;
            }


            if (!expresion.IsMatch(correo))
            {
                MostrarMensajeError("Correo no es del dominio @correo.com");
                return;
            }
            Usuario usuario = new UsuarioController().ObtenerUsuario(correo);
            contraseña = CifrarContraseña(contraseña);
            if (usuario == null)
            {
                MostrarMensajeError("Correo equivocado");
                return;
            }

            if (!contraseña.Equals(usuario.contrasenia))
            {
                MostrarMensajeError("Contraseña incorrecta");
                return;
            }

            if (usuario.tipo.Equals("Gerente"))
            {
                ProgramaGerente programa= new ProgramaGerente();
                this.Hide();
                programa.ShowDialog();
                this.Show();                
                return;
            }

            if (usuario.tipo.Equals("Vendedor"))
            {
                ProgramaVendedor vendedor = new ProgramaVendedor();
                this.correo = correo;
                this.Hide();
                vendedor.ShowDialog();
                this.Show();               
                        
                return;
            }
          
        }

        public static string CifrarContraseña(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        private void MostrarMensajeError(string msg)
        {
            this.resultado.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.resultado.Caption = "Error";
            this.resultado.Text = msg;
            this.resultado.Show();
        }
    }
}
