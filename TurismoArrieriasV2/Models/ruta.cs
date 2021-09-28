
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrieriasV2.Models
{
    public class ruta
    {
        [Key]
        public int id { get; set; }
        public LinkedList<sitio> puntosConexion { get; set; }       
        public String region { get; set; }//a que municipio corresponde la ruta (Neira, Aranzazu, Salamina, Pacora o Aguadas).
        public int costo { get; set; }//costo promedio de seguir esta ruta.
        public int distancia { get; set; }//que tan largo es el recorrido si sigo esta ruta.
    }
}
