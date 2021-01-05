using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            CtHoadons = new HashSet<CtHoadon>();
        }

        public string Id { get; set; }
        public string MaPhieuDh { get; set; }
        public DateTime? NgayLap { get; set; }
        public DateTime? NgayXuat { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }
        public decimal? ThanhTien { get; set; }
        public int? TrangThai { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Phieudathang MaPhieuDhNavigation { get; set; }
        public virtual ICollection<CtHoadon> CtHoadons { get; set; }
    }
}
