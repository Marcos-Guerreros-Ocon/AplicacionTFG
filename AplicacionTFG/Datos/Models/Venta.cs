using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public string isbn { get; set; }
    }
}
