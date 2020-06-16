using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Perfil
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
