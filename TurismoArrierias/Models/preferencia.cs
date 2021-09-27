using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrierias.Models
{
    public class preferencia
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }
        public int prioridad { get; set; }//1- mas preferido ..... 10- menos preferido

    }
}
