using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurismoArrierias.Models
{
    public class usuario
    {
        String tipo;//admin, comerciante, usuario estandar
        String nombre;
        String preferencias;//gustos seleccionados por el usuario (separados por coma)
        int edad;
        String id;
        String genero;
        String lugarResidencia;//local o extranjero
    }
}
