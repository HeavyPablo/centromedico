﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Models
{
    public class Sucursal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public Comuna comuna { get; set; }
        public string fechaCreacion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
