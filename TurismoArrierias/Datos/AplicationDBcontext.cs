using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoArrierias.Models;

namespace TurismoArrierias.Datos
{
    public class AplicationDBcontext : DbContext
    {
        public AplicationDBcontext(DbContextOptions<AplicationDBcontext> options) : base(options)
        {

        }
        public DbSet<usuario> Usuario { get; set; }
        public DbSet<preferencia> Preferencia { get; set; }
        public DbSet<sitio> Sitio { get; set; }
        public DbSet<ruta> Ruta { get; set; }

    }
}
