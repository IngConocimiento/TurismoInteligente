using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurismoArrieriasV2.Datos;
using TurismoArrieriasV2.Models;

namespace TurismoArrieriasV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rutasController : ControllerBase
    {
        private readonly AplicationDBcontext _context;

        public rutasController(AplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/rutas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ruta>>> GetRuta()
        {
            return await _context.Ruta.ToListAsync();
        }

        // GET: api/rutas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ruta>> Getruta(int id)
        {
            var ruta = await _context.Ruta.FindAsync(id);

            if (ruta == null)
            {
                return NotFound();
            }

            return ruta;
        }

        // PUT: api/rutas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putruta(int id, ruta ruta)
        {
            if (id != ruta.id)
            {
                return BadRequest();
            }

            _context.Entry(ruta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!rutaExists(id))
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

        // POST: api/rutas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ruta>> Postruta(ruta ruta)
        {
            _context.Ruta.Add(ruta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getruta", new { id = ruta.id }, ruta);
        }

        // DELETE: api/rutas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteruta(int id)
        {
            var ruta = await _context.Ruta.FindAsync(id);
            if (ruta == null)
            {
                return NotFound();
            }

            _context.Ruta.Remove(ruta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool rutaExists(int id)
        {
            return _context.Ruta.Any(e => e.id == id);
        }
    }
}
