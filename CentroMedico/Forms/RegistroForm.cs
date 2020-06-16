using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Forms
{
    public class RegistroForm
    {
        [Required]
        public string nombreUsuario { get; set; }
        [Required]
        public string contrasena { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellidoPaterno { get; set; }
        [Required]
        public string apellidoMaterno { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string fechaNacimiento { get; set; }
        public string rol { get; set; }
    }
}
