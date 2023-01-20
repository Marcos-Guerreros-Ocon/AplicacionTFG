using System;

namespace Datos.Models
{
    /// <summary>
    /// Clase Usuario.
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// Campo idUsuario con sus getters y setters.
        /// </summary>
        public int idUsuario { get; set; }

        /// <summary>
        /// Campo nombre con sus getters y setters.
        /// </summary>
        public string nombre { get; set; }
        
        /// <summary>
        /// Campo apellidos con sus getters y setters.
        /// </summary>
        public string apellidos { get; set; }

        /// <summary>
        /// Campo correo con sus getters y setters.
        /// </summary>
        public string correo { get; set; }

        /// <summary>
        /// Campo contraseña con sus getters y setters.
        /// </summary>
        public string contrasenia { get; set; }

        /// <summary>
        /// Campo tipo con sus getters y setters.
        /// </summary>
        public string tipo { get; set; }

    }
}
