using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Agenda
    {
        public int id { get; set; }
        public string fecha { get; set; }
        public string estado { get; set; }
        public string dia { get; set; }
        public Semana semana { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }

    }
}
