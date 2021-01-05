using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Phieudathang
    {
        public Phieudathang()
        {
            CtPhieudathangs = new HashSet<CtPhieudathang>();
            Hoadons = new HashSet<Hoadon>();
        }

        public string Id { get; set; }
        public string MaKh { get; set; }
        public DateTime? NgayDat { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? TrangThai { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual ICollection<CtPhieudathang> CtPhieudathangs { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
