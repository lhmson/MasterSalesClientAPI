using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Chucvu
    {
        public Chucvu()
        {
            Lichsuchucvus = new HashSet<Lichsuchucvu>();
            Nhanviens = new HashSet<Nhanvien>();
            Phanquyens = new HashSet<Phanquyen>();
        }

        public string Id { get; set; }
        public string TenChucVu { get; set; }
        public string MaPhongBan { get; set; }
        public decimal? PhuCap { get; set; }
        public bool? IsTrgPb { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Phongban MaPhongBanNavigation { get; set; }
        public virtual ICollection<Lichsuchucvu> Lichsuchucvus { get; set; }
        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
        public virtual ICollection<Phanquyen> Phanquyens { get; set; }
    }
}
