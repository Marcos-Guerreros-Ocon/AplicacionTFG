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
    /// <summary>
    /// Clase encargada de realizar las operaciones CRUD de la clase Usuario llamando a la API
    /// </summary>
    public class UsuarioController
    {
        /// <summary>
        /// Método para obtener todos los usuarios que existen.
        /// </summary>
        /// <returns>Devuelve una lista de usuarios.</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Usuario");
            string json = HttpConnection.ResponseToJson(res);
            List<Usuario> lista = JsonSerializer.Deserialize<List<Usuario>>(json);

            return lista;

        }

        /// <summary>
        /// Método para obtener todos los vendedores que existen.
        /// </summary>
        /// <returns>Devuelve una lista de vendedores.</returns>
        public List<Usuario> ObtenerVendedores()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Usuario");
            string json = HttpConnection.ResponseToJson(res);
            List<Usuario> lista = JsonSerializer.Deserialize<List<Usuario>>(json);
            List<Usuario> vendedores = new List<Usuario>();

              foreach (Usuario usuario in lista)
            {
                if (!usuario.tipo.Equals("Gerente"))
                {
                    vendedores.Add(usuario);
                }
            }

            return vendedores;
        }

        /// <summary>
        /// Método encargado de obtener un listado de vendedores que contenga la busqueda indicada.
        /// </summary>
        /// <param name="busqueda">Busqueda por la que queramos que compruebes los campos del vendedor.</param>
        /// <returns>Devuelve una lista de vendedores que contengan la busqueda indicada.</returns>
        public List<Usuario> ObtenerVendedoresBusqueda(string busqueda)
        {
            List<Usuario> lista = ObtenerVendedores();
            List<Usuario> vendedores = new List<Usuario>();
            foreach (Usuario usuario in lista)
            {
                if (usuario.nombre.Contains(busqueda) || usuario.apellidos.Contains(busqueda) || usuario.correo.Contains(busqueda))
                {
                    vendedores.Add(usuario);
                }
            }
            return vendedores;
        }

        /// <summary>
        /// Método para obtener un usario con el id indicado.
        /// </summary>
        /// <param name="id">Id del usuario que queremos obtener.</param>
        /// <returns>Devuelve un usuario con el id indicado.</returns>
        public Usuario ObtenerUsuario(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Usuario/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Usuario usuario = JsonSerializer.Deserialize<Usuario>(json);

            return usuario;
        }

        /// <summary>
        /// Método para obtener un usuario con el correo indicado.
        /// </summary>
        /// <param name="correo">Correo del usuario que queremos obtener.</param>
        /// <returns>Devuelve un usuario con el correo indicado.</returns>
        public Usuario ObtenerUsuario(string correo)
        {
            List<Usuario> usuarios = ObtenerUsuarios();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.correo.Equals(correo))
                {
                    return usuario;
                }
            }

            return null;
        }

        /// <summary>
        /// Método para modificar un usuario.
        /// </summary>
        /// <param name="usuario">Usuario que queremos modificar.</param>
        /// <returns>Devuelve true en caso de modificarlo y false en caso contrario.</returns>
        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                Usuario usu = ObtenerUsuario(usuario.idUsuario);

                if (usu == null)
                {
                    return false;
                }

                if (usuario.contrasenia==null)
                {
                    usuario.contrasenia = usu.contrasenia;
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

        /// <summary>
        /// Método para insertar un usuario.
        /// </summary>
        /// <param name="usuario">Usuario que queremos insertar.</param>
        /// <returns>Devuelve true en caso de insertarlo y false en caso contrario.</returns>
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

        /// <summary>
        /// Método para borrar un usuario.
        /// </summary>s
        /// <param name="idUsuario">Correo del usuario que queremos borrar.</param>
        /// <returns>Devuelve true en caso de borrarlo y false en caso contrario.</returns>
        public bool BorrarUsuario(int idUsuario)
        {
            try
            {
                Usuario usu = ObtenerUsuario(idUsuario);

                if (usu == null)
                {
                    return false;
                }


                WebResponse res = HttpConnection.Send(null, "DELETE", $"api/Usuario/{idUsuario}");
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
