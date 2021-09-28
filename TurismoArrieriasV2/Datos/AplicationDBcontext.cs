using Microsoft.EntityFrameworkCore;
using TurismoArrieriasV2.Models;

namespace TurismoArrieriasV2.Datos
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
        public DbSet<imagensitio> ImagenSitio { get; set; }

    }
}
