using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Datos.Controllers
{
   public class GeneroController
    {
        public Genero ObtenerGenero(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Genero/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Genero genero = JsonSerializer.Deserialize<Genero>(json);
            return genero;
        }
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

        public List<Genero> ObtenerGeneros()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Genero");
            string json = HttpConnection.ResponseToJson(res);
            List<Genero> lista = JsonSerializer.Deserialize<List<Genero>>(json);

            return lista;
        }
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
