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
    public class NhommathangController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public NhommathangController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/Nhommathang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nhommathang>>> GetNhommathangs()
        {
            foreach (var nhom in _context.Nhommathangs)
            {
                foreach (var x in _context.Mathangs)
                {
                    if (x.MaNhomMh.Equals(nhom.Id))
                    {
                        nhom.Mathangs.Add(x);
                    }
                }
            }
            return await _context.Nhommathangs.ToListAsync();
        }

        // GET: api/Nhommathang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nhommathang>> GetNhommathang(string id)
        {
            var nhommathang = await _context.Nhommathangs.FindAsync(id);

            if (nhommathang == null)
            {
                return NotFound();
            }

            return nhommathang;
        }

        // PUT: api/Nhommathang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhommathang(string id, Nhommathang nhommathang)
        {
            if (id != nhommathang.Id)
            {
                return BadRequest();
            }

            _context.Entry(nhommathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhommathangExists(id))
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

        // POST: api/Nhommathang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Nhommathang>> PostNhommathang(Nhommathang nhommathang)
        {
            _context.Nhommathangs.Add(nhommathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NhommathangExists(nhommathang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNhommathang", new { id = nhommathang.Id }, nhommathang);
        }

        // DELETE: api/Nhommathang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhommathang(string id)
        {
            var nhommathang = await _context.Nhommathangs.FindAsync(id);
            if (nhommathang == null)
            {
                return NotFound();
            }

            _context.Nhommathangs.Remove(nhommathang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NhommathangExists(string id)
        {
            return _context.Nhommathangs.Any(e => e.Id == id);
        }
    }
}
