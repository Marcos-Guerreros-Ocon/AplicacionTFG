using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Libro
    {
        public string isbn { get; set; }
        public int idGenero { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
    }
}
