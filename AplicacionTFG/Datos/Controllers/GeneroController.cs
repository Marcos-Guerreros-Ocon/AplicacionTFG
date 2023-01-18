using Datos.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Datos.Controllers
{
   /// <summary>
   /// Clase para realizar las operaciones CRUD de la clase Género llamando a la API.
   /// </summary>
    public class GeneroController
    {

        /// <summary>
        /// Método para obtener todos los géneros que existen.
        /// </summary>
        /// <returns>Devuelve una lista de géneros.</returns>
        public List<Genero> ObtenerGeneros()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Genero");
            string json = HttpConnection.ResponseToJson(res);
            List<Genero> lista = JsonSerializer.Deserialize<List<Genero>>(json);

            return lista;
        }

        /// <summary>
        /// Método encargado de obtener un género con el id indicado.
        /// </summary>
        /// <param name="id">Id del género que queremos obtener.</param>
        /// <returns>Devuelve el género con el id indicado.</returns>
        public Genero ObtenerGenero(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Genero/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Genero genero = JsonSerializer.Deserialize<Genero>(json);
            return genero;
        }

        /// <summary>
        /// Método encargado de obtener un género con el nombre indicado.
        /// </summary>
        /// <param name="nombre">Nombre del género que queremos obtener.</param>
        /// <returns>Devuelve el género con el nombre indicado.</returns>
        public Genero ObtenerGenero(string nombre)
        {
            List<Genero> lista = ObtenerGeneros();
            foreach (Genero genero in lista)
            {
                if (genero.nombre.Equals(nombre))
                {
                    return genero;
                }
            }
            return null;
        }

        /// <summary>
        /// Método encargado de insertar un género
        /// </summary>
        /// <param name="genero">Género que queremos insertar</param>
        /// <returns>Devuelve true en caso de insertarlo y false en caso contrario.</returns>
        public bool InsertarGenero(Genero genero)
        {
            try
            {          

                string json = JsonSerializer.Serialize(genero);
                WebResponse res = HttpConnection.Send(json, "POST", "api/Genero");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para borrar un género.
        /// </summary>
        /// <param name="idGenero">Id del género que queremos borrar.</param>
        /// <returns>Devuelve true en caso de borrarlo y false en caso contrario.</returns>
        public bool BorrarGenero(int idGenero)
        {
            try
            {
                if (ObtenerGenero(idGenero)==null)
                {
                    return false;
                }

                WebResponse res = HttpConnection.Send(null, "DELETE", $"api/Genero/{idGenero}");
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
