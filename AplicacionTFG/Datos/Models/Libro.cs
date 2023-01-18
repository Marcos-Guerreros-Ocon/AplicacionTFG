namespace Datos.Models
{
    /// <summary>
    /// Clase Libro.
    /// </summary>
    public class Libro
    {
        /// <summary>
        /// Campo ISBN con sus gettets y setters.
        /// </summary>
        public string isbn { get; set; }

        /// <summary>
        /// Campo idGenero con sus getters y setters.
        /// </summary>
        public int idGenero { get; set; }

        /// <summary>
        /// Campo titulo con sus getters y setters.
        /// </summary>
        public string titulo { get; set; }
        
        /// <summary>
        /// Campo autor con sus getters y setters.
        /// </summary>
        public string autor { get; set; }

        /// <summary>
        /// Campo precio con sus getters y setters.
        /// </summary>
        public int precio { get; set; }

        /// <summary>
        /// Campo stock con sus getters y setters.
        /// </summary>
        public int stock { get; set; }
    }
}
