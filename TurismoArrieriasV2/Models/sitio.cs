using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TurismoArrieriasV2.Models;

namespace TurismoArrieriasV2.Models
{
    public class sitio
    {
        [Key]
        public int id { get; set; }
        public int posicionX { get; set; }//coordenadas
        public int posicionY { get; set; }
        public LinkedList<imagensitio> galeria { get; set; }
        public String caracteristicas { get; set; }//guarda el compendio de preferencias para compararlas con las que selecciona el usuario
    }
}
