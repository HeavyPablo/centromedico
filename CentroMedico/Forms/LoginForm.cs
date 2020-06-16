using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CentroMedico.Forms
{
    public class LoginForm
    {
        [Required]
        public string nombreUsuario { get; set; }

        [Required]
        public string contrasena { get; set; }
    }
}
