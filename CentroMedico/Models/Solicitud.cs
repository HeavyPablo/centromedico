using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Solicitud
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Usuario paciente { get; set; }
        public Medico medico { get; set; }
        public Sucursal sucursal { get; set; }
        public Boleta boleta { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
