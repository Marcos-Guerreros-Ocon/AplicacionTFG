using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Datos.Controllers

{   /// <summary>
    /// Clase para realizar las operaciones CRUD de la clase Libro llamando a la API.
    /// </summary>
    public class LibrosController
    {
        /// <summary>
        /// Método encargado de obtener un listado de los libros.
        /// </summary>
        /// <returns>Devuelve una lista de libros</returns>
        public List<Libro> ObtenerLibros()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Libro");
            string json = HttpConnection.ResponseToJson(res);
            List<Libro> lista = JsonSerializer.Deserialize<List<Libro>>(json);

            return lista;
        }

        /// <summary>
        /// Método encargado de obtener un libro con el isbn indicado.
        /// </summary>
        /// <param name="isbn">ISBN del libro que queremos obtener.</param>
        /// <returns>Devuelve el libro con el ISBN indicado</returns>
        public Libro ObtenerLibro(string isbn)
        {
            WebResponse res = HttpConnection.Send(null, "GET", $"api/Libro/{isbn}");
            if (res==null)
            {
                return null;
            }
            string json = HttpConnection.ResponseToJson(res);
            Libro libro= JsonSerializer.Deserialize<Libro>(json);
            return libro;
        }        

        /// <summary>
        /// Método encargado de insertar un libro.
        /// </summary>
        /// <param name="libro">Libro que queremos insertar.</param>
        /// <returns>Devuelve true en caso de insertar el libro y false en caso contrario.</returns>
        public bool InsertarLibro(Libro libro)
        {
            try
            {
                if (ObtenerLibro(libro.isbn)!=null)
                {
                    return false;
                }

                string json = JsonSerializer.Serialize(libro);
                WebResponse res = HttpConnection.Send(json, "POST", "api/Libro");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        /// <summary>
        /// Método encargado de borrar un libro.
        /// </summary>
        /// <param name="isbn">ISBN del libro que queremos borrar.</param>
        /// <returns>Devuelve true en caso de borrarlo y false en caso contrario.</returns>
        public bool BorrarLibro(string isbn)
        {
            try
            {
                if (ObtenerLibro(isbn)==null)
                {
                    return false;
                }

                WebResponse res = HttpConnection.Send(null, "DELETE", $"api/Libro/{isbn}");
                string json = HttpConnection.ResponseToJson(res);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        
        /// <summary>
        /// Método encargado de modificar un libro.
        /// </summary>
        /// <param name="libro">Libro que queremos modificar.</param>
        /// <returns>Devuelve true en caso de modificarlo y false en caso contrario.</returns>
        public bool ModificarLibro(Libro libro)
        {
            try
            {
                if (ObtenerLibro(libro.isbn) == null)
                {
                    return false;
                }

                string json = JsonSerializer.Serialize(libro);
                WebResponse res = HttpConnection.Send(json, "PUT", $"api/Libro/{libro.isbn}");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método encargado de obtener un listado de libros que contenga la busqueda indicada.
        /// </summary>
        /// <param name="busqueda">Busqueda por la que queramos que compruebes los campos del libro.</param>
        /// <returns>Devuelve una lista de libros que contengan la busqueda indicada.</returns>
        public List<Libro> ObtenerLibrosPorBusqueda(string busqueda)
        {
            List<Libro>libros = ObtenerLibros();
            List<Libro> lista = new List<Libro>();
            foreach (Libro libro in libros)
            {
                if (libro.isbn.Contains(busqueda)||libro.titulo.Contains(busqueda) || libro.autor.Contains(busqueda))
                {
                    lista.Add(libro);
                }
            }

            return lista;
        }
        
        /// <summary>
        /// Método encargado de obntener un listado de libros que su género coincida con alguna de la lista de géneros indicada.
        /// </summary>
        /// <param name="generos">Lista de géneros por la que queremos filtrar.</param>
        /// <returns>Devuelve una lista de libros que coinciden con algún género de la lista.</returns>
        public List<Libro> ObtenerLibrosPorGenero(List<string> generos)
        {
            List<Libro> listaLibros = new List<Libro>();
            List<Libro> lista = ObtenerLibros();

            Genero genero;
            foreach (Libro libro in lista)
            {
                genero = new GeneroController().ObtenerGenero(libro.idGenero);

                foreach (string nombreGenero in generos)
                {
                    if (genero.nombre.Equals(nombreGenero))
                    {
                        listaLibros.Add(libro);
                    }
                }
            }

            return listaLibros;
        }

        /// <summary>
        /// Método encargado de obntener un listado de libros que su autor coincida con alguna de la lista de autores indicada.
        /// </summary>
        /// <param name="autores">Lista de autores por la que queremos filtrar.</param>
        /// <returns>Devuelve una lista de libros que coinciden con algún autor de la lista.</returns>
        public List<Libro> ObtenerLibrosPorAutor(List<string> autores)
        {
            List<Libro> listaLibros = new List<Libro>();

            List<Libro> lista = ObtenerLibros();

            foreach (Libro libro in lista)
            {
                foreach (string nombreAutor in autores)
                {
                    if (libro.autor.Equals(nombreAutor))
                    {
                        listaLibros.Add(libro);
                    }
                }
            }

            return listaLibros;
        }

        /*
        public List<Libro> ObtenerLibrosPorPrecio(List<int> precios)
        {
            List<Libro> listaLibros = new List<Libro>();

            List<Libro> lista = ObtenerLibros();

            foreach (Libro libro in lista)
            {
                foreach (int precio in precios)
                {
                    if (libro.precio ==precio)
                    {
                        listaLibros.Add(libro);
                    }
                }
            }

            return listaLibros;
        }
        public List<Libro> ObtenerLibrosPorStock(List<int> stocks)
        {
            List<Libro> listaLibros = new List<Libro>();

            List<Libro> lista = ObtenerLibros();

            foreach (Libro libro in lista)
            {
                foreach (int stock in stocks)
                {
                    if (libro.stock == stock)
                    {
                        listaLibros.Add(libro);
                    }
                }
            }

            return listaLibros;
        }
        */

    }
}
