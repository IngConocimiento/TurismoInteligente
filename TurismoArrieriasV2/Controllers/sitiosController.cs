using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoArrieriasV2.Datos;
using TurismoArrieriasV2.Models;

namespace TurismoArrieriasV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sitiosController : ControllerBase
    {
        private readonly AplicationDBcontext _context;

        public sitiosController(AplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/sitios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<sitio>>> GetSitio()
        {
            return await _context.Sitio.ToListAsync();
        }

        // GET: api/sitios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<sitio>> Getsitio(int id)
        {
            var sitio = await _context.Sitio.FindAsync(id);

            if (sitio == null)
            {
                return NotFound();
            }

            return sitio;
        }

        // PUT: api/sitios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putsitio(int id, sitio sitio)
        {
            if (id != sitio.id)
            {
                return BadRequest();
            }

            _context.Entry(sitio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sitioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/sitios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<sitio>> Postsitio(sitio sitio)
        {
            _context.Sitio.Add(sitio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getsitio", new { id = sitio.id }, sitio);
        }

        // DELETE: api/sitios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletesitio(int id)
        {
            var sitio = await _context.Sitio.FindAsync(id);
            if (sitio == null)
            {
                return NotFound();
            }

            _context.Sitio.Remove(sitio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool sitioExists(int id)
        {
            return _context.Sitio.Any(e => e.id == id);
        }
    }
}
