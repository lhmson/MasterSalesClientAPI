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
    public class PhieudathangController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public PhieudathangController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/Phieudathang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Phieudathang>>> GetPhieudathangs()
        {
            return await _context.Phieudathangs.ToListAsync();
        }

        // GET: api/Phieudathang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Phieudathang>> GetPhieudathang(string id)
        {
            var phieudathang = await _context.Phieudathangs.FindAsync(id);

            if (phieudathang == null)
            {
                return NotFound();
            }

            return phieudathang;
        }

        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<Phieudathang>>> GetPhieudathangsOfKhachhang(string id)
        {
            var phieudathangs = from order in _context.Phieudathangs
                                select order;
            List<Phieudathang> phieudathangsofkhachhang = new List<Phieudathang>();
            foreach (var x in phieudathangs)
            {
                if (x.MaKh.Equals(id))
                {
                    foreach (var dt in _context.CtPhieudathangs)
                    {
                        if (x.Id.Equals(dt.MaPhieuDh))
                        {
                            x.CtPhieudathangs.Add(dt);
                        }
                    }
                    phieudathangsofkhachhang.Add(x);
                }
            }
            return phieudathangsofkhachhang;
        }

        // PUT: api/Phieudathang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhieudathang(string id, Phieudathang phieudathang)
        {
            if (id != phieudathang.Id)
            {
                return BadRequest();
            }

            _context.Entry(phieudathang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhieudathangExists(id))
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

        // POST: api/Phieudathang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Phieudathang>> PostPhieudathang(Phieudathang phieudathang)
        {
            _context.Phieudathangs.Add(phieudathang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PhieudathangExists(phieudathang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPhieudathang", new { id = phieudathang.Id }, phieudathang);
        }

        // DELETE: api/Phieudathang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhieudathang(string id)
        {
            var phieudathang = await _context.Phieudathangs.FindAsync(id);
            if (phieudathang == null)
            {
                return NotFound();
            }

            _context.Phieudathangs.Remove(phieudathang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhieudathangExists(string id)
        {
            return _context.Phieudathangs.Any(e => e.Id == id);
        }
    }
}
