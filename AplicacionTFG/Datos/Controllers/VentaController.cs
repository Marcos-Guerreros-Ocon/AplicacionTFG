using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Datos.Controllers
{
    /// <summary>
    /// Clase encargada de realizar las operaciones CRUD de la clase Venta llamando a la API.
    /// </summary>
    public class VentaController
    {
        /// <summary>
        /// Método encargado de obtener las ventas existentes.
        /// </summary>
        /// <returns>Devuelve una lista de las ventas existentes.</returns>
        public List<Venta> ObtenerVentas()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Venta");
            string json = HttpConnection.ResponseToJson(res);
            List<Venta> lista = JsonSerializer.Deserialize<List<Venta>>(json);

            return lista;

        }

        /// <summary>
        /// Método encargado de obtener una venta por el id indicado.
        /// </summary>
        /// <param name="id">Id de la venta que queramos obtener.</param>
        /// <returns>Devuevle una venta con el id indicado.</returns>
        public Venta ObtenerVenta(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Venta/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Venta venta = JsonSerializer.Deserialize<Venta>(json);

            return venta;
        }

        /// <summary>
        /// Método encargado de obtener una lista de las ventas realizadas
        /// por el id del usuario con el id indicado.
        /// </summary>
        /// <param name="idUsuario">Id del usuario que ha realizado las ventas.</param>
        /// <returns>Devuelve una lista de las ventas realizadas por el id del usuario indicado.</returns>
        public List<Venta> ObtenerVentasDelVendedor(int idUsuario)
        {
            List<Venta> ventas = ObtenerVentas();
            List<Venta> lista = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                if (venta.idUsuario == idUsuario)
                {
                    lista.Add(venta);
                }

            }
            return lista;
        }
        public List<Venta> ObtenerVentasGenero(int idGenero)
        {
            List<Venta> ventas = ObtenerVentas();
            List<Venta> lista = new List<Venta>();
            Libro libro;
            foreach (Venta venta in ventas)
            {
                libro = new LibrosController().ObtenerLibro(venta.isbn);
                if (libro.idGenero == idGenero)
                {
                    lista.Add(venta);
                }

            }
            return lista;
        }
        /// <summary>
        /// Método encargo de obtener una lista de las ventas realizadas del libro con el isbn indicado.
        /// </summary>
        /// <param name="isbn">ISBN del libro que ha sido vendido.</param>
        /// <returns>Devuelve una lista de las ventas del libro indicado.</returns>
        public List<Venta> ObtenerVentasDelLibro(string isbn)
        {
            List<Venta> ventas = ObtenerVentas();
            List<Venta> lista = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                if (venta.isbn.Equals(isbn))
                {
                    lista.Add(venta);
                }

            }
            return lista;
        }

        /// <summary>
        /// Método encargado de insertar una venta.
        /// </summary>
        /// <param name="venta">Venta que queremos insertar.</param>
        /// <returns>Devuelve true en caso de insertarlo y false en caso contrario.</returns>
        public bool InsertarVenta(Venta venta)
        {
            try
            {
                string json = JsonSerializer.Serialize(venta);
                WebResponse res = HttpConnection.Send(json, "POST", "api/Venta");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Venta> ObtenerVentaPorBusqueda(string busqueda)
        {
            List<Venta> ventas = ObtenerVentas();
            List<Venta> lista = new List<Venta>();
            Libro libro;
            Usuario vendedor;
            foreach (Venta venta in ventas)
            {
                libro = new LibrosController().ObtenerLibro(venta.isbn);
                vendedor = new UsuarioController().ObtenerUsuario(venta.idUsuario);

                if (venta.isbn.Contains(busqueda) || libro.titulo.Contains(busqueda) ||
                    libro.autor.Contains(busqueda) || vendedor.nombre.Contains(busqueda) ||
                    vendedor.apellidos.Contains(busqueda) || vendedor.correo.Contains(busqueda))
                {
                    lista.Add(venta);
                }
            }

            return lista;
        }
    }
}
