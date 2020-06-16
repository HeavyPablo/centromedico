using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Semana
    {
        public int id { get; set; }
        public string fechaInicio { get; set; }
        public string fechaTermino { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
