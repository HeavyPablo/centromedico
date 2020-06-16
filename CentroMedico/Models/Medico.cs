using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Medico
    {
        public int id { get; set; }
        public string profesion { get; set; }
        public Usuario usuario { get; set; }
        public Agenda agenda { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
