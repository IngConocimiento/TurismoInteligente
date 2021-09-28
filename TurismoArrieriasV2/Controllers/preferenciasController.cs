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
    public class preferenciasController : ControllerBase
    {
        private readonly AplicationDBcontext _context;

        public preferenciasController(AplicationDBcontext context)
        {
            _context = context;
        }

        // GET: api/preferencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<preferencia>>> GetPreferencia()
        {
            return await _context.Preferencia.ToListAsync();
        }

        // GET: api/preferencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<preferencia>> Getpreferencia(int id)
        {
            var preferencia = await _context.Preferencia.FindAsync(id);

            if (preferencia == null)
            {
                return NotFound();
            }

            return preferencia;
        }

        // PUT: api/preferencias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putpreferencia(int id, preferencia preferencia)
        {
            if (id != preferencia.id)
            {
                return BadRequest();
            }

            _context.Entry(preferencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!preferenciaExists(id))
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

        // POST: api/preferencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<preferencia>> Postpreferencia(preferencia preferencia)
        {
            _context.Preferencia.Add(preferencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getpreferencia", new { id = preferencia.id }, preferencia);
        }

        // DELETE: api/preferencias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletepreferencia(int id)
        {
            var preferencia = await _context.Preferencia.FindAsync(id);
            if (preferencia == null)
            {
                return NotFound();
            }

            _context.Preferencia.Remove(preferencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool preferenciaExists(int id)
        {
            return _context.Preferencia.Any(e => e.id == id);
        }
    }
}
