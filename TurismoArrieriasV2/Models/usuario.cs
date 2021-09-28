using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrieriasV2.Models
{
    public class usuario
    {
        [Key]//clave primaria de la clase
        public int id { get; set; }
        
        [Required(ErrorMessage = "el campo tipo es obligatorio")]
        [Display(Name = "tipo de usuario (administrador, comerciante o usuario estandar)")]
        public String tipo { get; set; }//admin, comerciante, usuario estandar

        [Required(ErrorMessage = "el campo nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public String nombre { get; set; }

        //[Required(ErrorMessage = "el campo nombre del curso es obligatorio")]
        //[Display(Name = "Nombre del curso")]
        public String preferencias { get; set; }//gustos seleccionados por el usuario (el campo es llenado por la seleccion del usuario en la vista las preferencias estan separadas por coma)

        [Required(ErrorMessage = "el campo edad es obligatorio")]
        [Range(0, 100, ErrorMessage = "edades validas 1 - 100")]
        [Display(Name = "edad")]
        public int edad { get; set; }

        //[Required(ErrorMessage = "el campo nombre del curso es obligatorio")]
        [Display(Name = "genero")]
        public String genero { get; set; }

        [Required(ErrorMessage = "el lugar de residencia es obligatorio")]
        [Display(Name = "lugar de residencia")]
        public String lugarResidencia { get; set; }//local o extranjero
       
    }
}
