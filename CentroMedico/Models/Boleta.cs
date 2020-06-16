using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Boleta
    {
        public int id { get; set; }
        public string monto { get; set; }
        public string estado { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
