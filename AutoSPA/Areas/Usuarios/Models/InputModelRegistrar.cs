using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSPA.Areas.Usuarios.Models
{
    public class InputModelRegistrar
    {
        [Required(ErrorMessage = "Campo Requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string domicilio { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string DNI { get; set; }
       
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime fecha_nac { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [EmailAddress(ErrorMessage = "Debe ser una casilla de correos valida")]
        public string email { get; set; }

        [Display(Name ="Contraseña")]
        [StringLength(50,ErrorMessage ="la contraseña no puese ser tan larga")]
        public string pass { get; set; }

    }
}
