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
    public class TuVanKhController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public TuVanKhController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/TuVanKh
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TuVanKh>>> GetTuVanKhs()
        {
            return await _context.TuVanKhs.ToListAsync();
        }

        // GET: api/TuVanKh/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TuVanKh>> GetTuVanKh(string id)
        {
            var tuVanKh = await _context.TuVanKhs.FindAsync(id);

            if (tuVanKh == null)
            {
                return NotFound();
            }

            return tuVanKh;
        }

        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<TuVanKh>>> GetTuvansOfKhachhang(string id)
        {
            var tuvans = from question in _context.TuVanKhs
                                select question;
            List<TuVanKh> tuvansofkhachhang = new List<TuVanKh>();
            foreach (var x in tuvans)
            {
                if (x.MaKh.Equals(id))
                {
                    tuvansofkhachhang.Add(x);
                }
            }
            return tuvansofkhachhang;
        }

        // PUT: api/TuVanKh/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTuVanKh(string id, TuVanKh tuVanKh)
        {
            if (id != tuVanKh.Id)
            {
                return BadRequest();
            }

            _context.Entry(tuVanKh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TuVanKhExists(id))
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

        // POST: api/TuVanKh
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TuVanKh>> PostTuVanKh(TuVanKh tuVanKh)
        {
            _context.TuVanKhs.Add(tuVanKh);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TuVanKhExists(tuVanKh.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTuVanKh", new { id = tuVanKh.Id }, tuVanKh);
        }

        // DELETE: api/TuVanKh/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTuVanKh(string id)
        {
            var tuVanKh = await _context.TuVanKhs.FindAsync(id);
            if (tuVanKh == null)
            {
                return NotFound();
            }

            _context.TuVanKhs.Remove(tuVanKh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TuVanKhExists(string id)
        {
            return _context.TuVanKhs.Any(e => e.Id == id);
        }
    }
}
