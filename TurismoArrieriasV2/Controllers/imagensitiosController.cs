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
    public class imagensitiosController : ControllerBase
    {
        private readonly AplicationDBcontext _context;

        public imagensitiosController(AplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/imagensitios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<imagensitio>>> GetImagenSitio()
        {
            return await _context.ImagenSitio.ToListAsync();
        }

        // GET: api/imagensitios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<imagensitio>> Getimagensitio(int id)
        {
            var imagensitio = await _context.ImagenSitio.FindAsync(id);

            if (imagensitio == null)
            {
                return NotFound();
            }

            return imagensitio;
        }

        // PUT: api/imagensitios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putimagensitio(int id, imagensitio imagensitio)
        {
            if (id != imagensitio.id)
            {
                return BadRequest();
            }

            _context.Entry(imagensitio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!imagensitioExists(id))
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

        // POST: api/imagensitios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<imagensitio>> Postimagensitio(imagensitio imagensitio)
        {
            _context.ImagenSitio.Add(imagensitio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getimagensitio", new { id = imagensitio.id }, imagensitio);
        }

        // DELETE: api/imagensitios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteimagensitio(int id)
        {
            var imagensitio = await _context.ImagenSitio.FindAsync(id);
            if (imagensitio == null)
            {
                return NotFound();
            }

            _context.ImagenSitio.Remove(imagensitio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool imagensitioExists(int id)
        {
            return _context.ImagenSitio.Any(e => e.id == id);
        }
    }
}
