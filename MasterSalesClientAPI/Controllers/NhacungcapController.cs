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
    public class NhacungcapController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public NhacungcapController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/Nhacungcap
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhacungcap>>> GetNhacungcaps()
        {
            return await _context.Nhacungcaps.ToListAsync();
        }

        // GET: api/Nhacungcap/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhacungcap>> GetNhacungcap(string id)
        {
            var nhacungcap = await _context.Nhacungcaps.FindAsync(id);

            if (nhacungcap == null)
            {
                return NotFound();
            }

            return nhacungcap;
        }

        // PUT: api/Nhacungcap/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhacungcap(string id, Nhacungcap nhacungcap)
        {
            if (id != nhacungcap.Id)
            {
                return BadRequest();
            }

            _context.Entry(nhacungcap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhacungcapExists(id))
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

        // POST: api/Nhacungcap
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nhacungcap>> PostNhacungcap(Nhacungcap nhacungcap)
        {
            _context.Nhacungcaps.Add(nhacungcap);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NhacungcapExists(nhacungcap.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNhacungcap", new { id = nhacungcap.Id }, nhacungcap);
        }

        // DELETE: api/Nhacungcap/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhacungcap(string id)
        {
            var nhacungcap = await _context.Nhacungcaps.FindAsync(id);
            if (nhacungcap == null)
            {
                return NotFound();
            }

            _context.Nhacungcaps.Remove(nhacungcap);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhacungcapExists(string id)
        {
            return _context.Nhacungcaps.Any(e => e.Id == id);
        }
    }
}
