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
    public class KhachhangController : ControllerBase
    {
        private readonly QLKinhDoanhContext _context;

        public KhachhangController(QLKinhDoanhContext context)
        {
            _context = context;
        }

        // GET: api/Khachhang
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Khachhang>>> GetKhachhangs()
        {
            return await _context.Khachhangs.ToListAsync();
        }

        // GET: api/Khachhang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Khachhang>> GetKhachhang(string id)
        {
            var khachhang = await _context.Khachhangs.FindAsync(id);

            if (khachhang == null)
            {
                return NotFound();
            }

            return khachhang;
        }

        // PUT: api/Khachhang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhachhang(string id, Khachhang khachhang)
        {
            if (id != khachhang.Id)
            {
                return BadRequest();
            }

            _context.Entry(khachhang).State = EntityState.Modified;
            var khachhangs = from user in _context.Khachhangs
                             select user;
            foreach (var x in khachhangs)
            {
                if (x.Sdt.Equals(khachhang.Sdt) && x.Id != khachhang.Id)
                {
                    return Conflict();
                }
            }
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhachhangExists(id))
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

        // POST: api/Khachhang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Khachhang>> PostKhachhang(Khachhang khachhang)
        {
            var khachhangs = from user in _context.Khachhangs
                             select user;
            foreach (var x in khachhangs)
            {
                if (x.TenDangNhap.Equals(khachhang.TenDangNhap) || x.Sdt.Equals(khachhang.Sdt))
                {
                    return Conflict();
                }
            }

            _context.Khachhangs.Add(khachhang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KhachhangExists(khachhang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKhachhang", new { id = khachhang.Id }, khachhang);
        }

        // POST: api/Khachhang/login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("login")]
        public async Task<ActionResult<Khachhang>> PostKhachHangLogin(Khachhang khachhang)
        {
            var khachhangs = from user in _context.Khachhangs
                             select user;
            foreach (var x in khachhangs)
            {
                if (x.TenDangNhap.Equals(khachhang.TenDangNhap) && x.MatKhau.Equals(khachhang.MatKhau))
                {
                    khachhang.Id = x.Id;
                    khachhang.TenKh = x.TenKh;
                    khachhang.DiaChi = x.DiaChi;
                    khachhang.Sdt = x.Sdt;
                    khachhang.Avatar = x.Avatar;
                    khachhang.TenDangNhap = x.TenDangNhap;
                    khachhang.MatKhau = x.MatKhau;
                    khachhang.IsDeleted = x.IsDeleted;
                    return Ok(khachhang);
                }
            }
            //if(taikhoans.Where(x => x.TenTaiKhoan.Equals(taikhoan.TenTaiKhoan) && x.MatKhau.Equals(taikhoan.MatKhau)).Count() > 0){
            //    return Ok(taikhoan);
            //}

            return NotFound();
        }

        // DELETE: api/Khachhang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhachhang(string id)
        {
            var khachhang = await _context.Khachhangs.FindAsync(id);
            if (khachhang == null)
            {
                return NotFound();
            }

            _context.Khachhangs.Remove(khachhang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhachhangExists(string id)
        {
            return _context.Khachhangs.Any(e => e.Id == id);
        }
    }
}
