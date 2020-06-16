using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public Rol rol { get; set; }
        public Perfil perfil { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
