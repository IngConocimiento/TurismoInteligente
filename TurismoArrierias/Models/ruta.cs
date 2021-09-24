using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrierias.Models
{
    public class ruta
    {
        LinkedList<sitio> puntosConexion;
        String region;//a que municipio corresponde la ruta (Neira, Aranzazu, Salamina, Pacora o Aguadas).
        int costo;//costo promedio de seguir esta ruta.
        int distancia;//que tan largo es el recorrido si sigo esta ruta.
    }
}
