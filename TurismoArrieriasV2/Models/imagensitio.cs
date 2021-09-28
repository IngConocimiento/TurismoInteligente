using System.ComponentModel.DataAnnotations;

namespace TurismoArrieriasV2.Models
{
    public class imagensitio
    {
        [Key]
        public int id { get; set; }

        public string url { get; set; }

        public sitio sitio { get; set; }
    }
}
