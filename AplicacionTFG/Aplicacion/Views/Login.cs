
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
                MessageBox.Show("El campo correo esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contraseña == "")
            {
                MessageBox.Show("El campo contraseña vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!expresion.IsMatch(correo))
            {
                MessageBox.Show("Correo no es del dominio @correo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Usuario usuario = new UsuarioController().ObtenerUsuario(correo);
            contraseña = CifrarContraseña(contraseña);
            if (usuario == null)
            {
                MessageBox.Show("Correo equivocado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!contraseña.Equals(usuario.contrasenia))
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.tipo.Equals("gerente"))
            {
                ProgramaGerente programa= new ProgramaGerente();
                this.Hide();
                programa.ShowDialog();
                this.Show();                
                return;
            }

            if (usuario.tipo.Equals("vendedor"))
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

    }
}
