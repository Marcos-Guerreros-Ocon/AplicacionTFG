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
    public class VentaController
    {

        public List<Venta> ListarVentas()
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Venta");
            string json = HttpConnection.ResponseToJson(res);
            List<Venta> lista = JsonSerializer.Deserialize<List<Venta>>(json);

            return lista;

        }
        public Venta ObtenerVenta(int id)
        {
            WebResponse res = HttpConnection.Send(null, "GET", "api/Venta/" + id);
            string json = HttpConnection.ResponseToJson(res);
            Venta venta = JsonSerializer.Deserialize<Venta>(json);

            return venta;
        }
        public List<Venta>ObtenerVentasDelVendedor(int idUsuario)
        {
            List<Venta> ventas = ListarVentas();
            List<Venta> lista = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                if (venta.idUsuario==idUsuario)
                {
                    lista.Add(venta);
                }

            }
            return lista;
        }
        public List<Venta> ObtenerVentasDelLibro(string isbn)
        {
            List<Venta> ventas = ListarVentas();
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

       
    }
}
