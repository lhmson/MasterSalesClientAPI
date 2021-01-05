using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MasterSalesClientAPI.Models;

namespace MasterSalesClientAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathangController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public MathangController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/Mathang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mathang>>> GetMathangs()
        {
            return await _context.Mathangs.ToListAsync();
        }

        // GET: api/Mathang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mathang>> GetMathang(string id)
        {
            var mathang = await _context.Mathangs.FindAsync(id);

            if (mathang == null)
            {
                return NotFound();
            }

            return mathang;
        }

        // PUT: api/Mathang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMathang(string id, Mathang mathang)
        {
            if (id != mathang.Id)
            {
                return BadRequest();
            }

            _context.Entry(mathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MathangExists(id))
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

        // POST: api/Mathang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mathang>> PostMathang(Mathang mathang)
        {
            _context.Mathangs.Add(mathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MathangExists(mathang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMathang", new { id = mathang.Id }, mathang);
        }

        // DELETE: api/Mathang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMathang(string id)
        {
            var mathang = await _context.Mathangs.FindAsync(id);
            if (mathang == null)
            {
                return NotFound();
            }

            _context.Mathangs.Remove(mathang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MathangExists(string id)
        {
            return _context.Mathangs.Any(e => e.Id == id);
        }
    }
}
