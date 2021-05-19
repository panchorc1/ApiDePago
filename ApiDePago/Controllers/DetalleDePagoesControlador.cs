using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDePago.Models;

namespace ApiDePago.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleDePagoesControlador : ControllerBase
    {
        private readonly ContextoDetallePago _context;

        public DetalleDePagoesControlador(ContextoDetallePago context)
        {
            _context = context;
        }

        // GET: api/DetalleDePagoesControlador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleDePago>>> GetdetalleDePagos()
        {
            return await _context.detalleDePagos.ToListAsync();
        }

        // GET: api/DetalleDePagoesControlador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleDePago>> GetDetalleDePago(int id)
        {
            var detalleDePago = await _context.detalleDePagos.FindAsync(id);

            if (detalleDePago == null)
            {
                return NotFound();
            }

            return detalleDePago;
        }

        // PUT: api/DetalleDePagoesControlador/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleDePago(int id, DetalleDePago detalleDePago)
        {
            if (id != detalleDePago.IDPago)
            {
                return BadRequest();
            }

            _context.Entry(detalleDePago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleDePagoExists(id))
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

        // POST: api/DetalleDePagoesControlador
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleDePago>> PostDetalleDePago(DetalleDePago detalleDePago)
        {
            _context.detalleDePagos.Add(detalleDePago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleDePago", new { id = detalleDePago.IDPago }, detalleDePago);
        }

        // DELETE: api/DetalleDePagoesControlador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleDePago(int id)
        {
            var detalleDePago = await _context.detalleDePagos.FindAsync(id);
            if (detalleDePago == null)
            {
                return NotFound();
            }

            _context.detalleDePagos.Remove(detalleDePago);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleDePagoExists(int id)
        {
            return _context.detalleDePagos.Any(e => e.IDPago == id);
        }
    }
}
