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
{
    public class LibrosController
    {
        public List<Libro> ObtenerLibros()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Libro");
            string json = HttpConnection.ResponseToJson(res);
            List<Libro> lista = JsonSerializer.Deserialize<List<Libro>>(json);

            return lista;
        }
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


    }
}
