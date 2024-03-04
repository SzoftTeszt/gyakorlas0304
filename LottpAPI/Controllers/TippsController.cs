using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LottoAdat.Models;
using LottpAPI.Data;

namespace LottpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TippsController : ControllerBase
    {
        private readonly LottpAPIContext _context;

        public TippsController(LottpAPIContext context)
        {
            _context = context;
        }

        // GET: api/Tipps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipp>>> GetTipp()
        {
          if (_context.Tipp == null)
          {
              return NotFound();
          }
            return await _context.Tipp.ToListAsync();
        }

        // GET: api/Tipps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipp>> GetTipp(int id)
        {
          if (_context.Tipp == null)
          {
              return NotFound();
          }
            var tipp = await _context.Tipp.FindAsync(id);

            if (tipp == null)
            {
                return NotFound();
            }

            return tipp;
        }

        // PUT: api/Tipps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipp(int id, Tipp tipp)
        {
            if (id != tipp.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TippExists(id))
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

        // POST: api/Tipps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipp>> PostTipp(Tipp tipp)
        {
          if (_context.Tipp == null)
          {
              return Problem("Entity set 'LottpAPIContext.Tipp'  is null.");
          }
            _context.Tipp.Add(tipp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipp", new { id = tipp.Id }, tipp);
        }

        // DELETE: api/Tipps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipp(int id)
        {
            if (_context.Tipp == null)
            {
                return NotFound();
            }
            var tipp = await _context.Tipp.FindAsync(id);
            if (tipp == null)
            {
                return NotFound();
            }

            _context.Tipp.Remove(tipp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TippExists(int id)
        {
            return (_context.Tipp?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
