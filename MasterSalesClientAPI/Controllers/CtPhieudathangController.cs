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
    public class CtPhieudathangController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public CtPhieudathangController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/CtPhieudathang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CtPhieudathang>>> GetCtPhieudathangs()
        {
            return await _context.CtPhieudathangs.ToListAsync();
        }

        // GET: api/CtPhieudathang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CtPhieudathang>> GetCtPhieudathang(string id)
        {
            var ctPhieudathang = await _context.CtPhieudathangs.FindAsync(id);

            if (ctPhieudathang == null)
            {
                return NotFound();
            }

            return ctPhieudathang;
        }

        // PUT: api/CtPhieudathang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCtPhieudathang(string id, CtPhieudathang ctPhieudathang)
        {
            if (id != ctPhieudathang.Id)
            {
                return BadRequest();
            }

            _context.Entry(ctPhieudathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CtPhieudathangExists(id))
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

        // POST: api/CtPhieudathang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CtPhieudathang>> PostCtPhieudathang(CtPhieudathang ctPhieudathang)
        {
            _context.CtPhieudathangs.Add(ctPhieudathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CtPhieudathangExists(ctPhieudathang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCtPhieudathang", new { id = ctPhieudathang.Id }, ctPhieudathang);
        }

        // DELETE: api/CtPhieudathang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCtPhieudathang(string id)
        {
            var ctPhieudathang = await _context.CtPhieudathangs.FindAsync(id);
            if (ctPhieudathang == null)
            {
                return NotFound();
            }

            _context.CtPhieudathangs.Remove(ctPhieudathang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CtPhieudathangExists(string id)
        {
            return _context.CtPhieudathangs.Any(e => e.Id == id);
        }
    }
}
