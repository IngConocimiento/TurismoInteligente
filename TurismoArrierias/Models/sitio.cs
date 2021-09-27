using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrierias.Models
{
    public class sitio
    {
        [Key]
        public int id { get; set; }
        int posicionX { get; set; }//coordenadas
        int posicionY { get; set; }
        String caracteristicas { get; set; }//guarda el compendio de preferencias para compararlas con las que selecciona el usuario
}
}
