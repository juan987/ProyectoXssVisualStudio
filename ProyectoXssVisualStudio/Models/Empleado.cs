using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoXssVisualStudio.Models
{
    public class Empleado
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { set; get; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Apellidos { set; get; }
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Email { set; get; }
        [DataType(DataType.Currency, ErrorMessage = "Introduzca un número")]
        public long Salario { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Pass { set; get; }
        [Compare("Pass", ErrorMessage = "El dato no coincide con el password")]
        public string Pass2 { set; get; }

    }
}