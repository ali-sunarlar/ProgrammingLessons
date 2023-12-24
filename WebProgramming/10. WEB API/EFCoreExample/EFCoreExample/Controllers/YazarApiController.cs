using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreExample.Models;

namespace EFCoreExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarApiController : ControllerBase
    {
        private readonly KitaplikContext _context;

        public YazarApiController(KitaplikContext context)
        {
            _context = context;
        }

        // GET: api/YazarApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Yazar>>> GetYazarlar()
        {
            return await _context.Yazarlar.ToListAsync();
        }

        // GET: api/YazarApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Yazar>> GetYazar(int id)
        {
            var yazar = await _context.Yazarlar.FindAsync(id);

            if (yazar == null)
            {
                return NotFound();
            }

            return yazar;
        }

        // PUT: api/YazarApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYazar(int id, Yazar yazar)
        {
            if (id != yazar.YazarID)
            {
                return BadRequest();
            }

            _context.Entry(yazar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YazarExists(id))
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

        // POST: api/YazarApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Yazar>> PostYazar(Yazar yazar)
        {
            _context.Yazarlar.Add(yazar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYazar", new { id = yazar.YazarID }, yazar);
        }

        // DELETE: api/YazarApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYazar(int id)
        {
            var yazar = await _context.Yazarlar.FindAsync(id);
            if (yazar == null)
            {
                return NotFound();
            }

            _context.Yazarlar.Remove(yazar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YazarExists(int id)
        {
            return _context.Yazarlar.Any(e => e.YazarID == id);
        }
    }
}
