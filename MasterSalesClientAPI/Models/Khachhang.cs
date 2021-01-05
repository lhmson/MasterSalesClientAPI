using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Hoadons = new HashSet<Hoadon>();
            Phieudathangs = new HashSet<Phieudathang>();
            TuVanKhs = new HashSet<TuVanKh>();
        }

        public string Id { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Avatar { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Phieudathang> Phieudathangs { get; set; }
        public virtual ICollection<TuVanKh> TuVanKhs { get; set; }
    }
}
