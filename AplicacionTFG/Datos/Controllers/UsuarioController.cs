using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Controllers
{
    public class UsuarioController
    {
        public List<Usuario> ListarUsuarios()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Usuario");
            string json = HttpConnection.ResponseToJson(res);
            List<Usuario> lista = JsonSerializer.Deserialize<List<Usuario>>(json);

            return lista;

        }

        public Usuario ObtenerUsuario(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Usuario/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Usuario usuario = JsonSerializer.Deserialize<Usuario>(json);

            return usuario;
        }

        public Usuario ObtenerUsuario(string correo)
        {
            List<Usuario> usuarios = ListarUsuarios();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.correo.Equals(correo))
                {
                    return usuario;
                }
            }

            return null;
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                Usuario usu = ObtenerUsuario(usuario.correo);

                if (usu == null)
                {
                    return false;
                }

                usuario.tipo = "Vendedor";
                string json = JsonSerializer.Serialize(usuario);
                WebResponse res = HttpConnection.Send(json, "PUT", $"api/Usuario/{usuario.idUsuario}");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertarUsuario(Usuario usuario)
        {
            try
            {
                Usuario usu = ObtenerUsuario(usuario.correo);

                if (usu != null)
                {
                    return false;
                }

                usuario.tipo = "Vendedor";
                string json = JsonSerializer.Serialize(usuario);
                WebResponse res = HttpConnection.Send(json, "POST", "api/Usuario");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BorrarUsuario(string correo)
        {
            try
            {
                Usuario usu = ObtenerUsuario(correo);

                if (usu == null)
                {
                    return false;
                }


                WebResponse res = HttpConnection.Send(null, "DELETE", $"api/Usuario/{correo}");
                string json = HttpConnection.ResponseToJson(res);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
