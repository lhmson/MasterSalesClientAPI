using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Bangthuong
    {
        public Bangthuong()
        {
            CtBangthuongs = new HashSet<CtBangthuong>();
        }

        public string Id { get; set; }
        public string MaTrgPb { get; set; }
        public DateTime? NgayLap { get; set; }
        public int? Thang { get; set; }
        public string MaPhong { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Phongban MaPhongNavigation { get; set; }
        public virtual Nhanvien MaTrgPbNavigation { get; set; }
        public virtual ICollection<CtBangthuong> CtBangthuongs { get; set; }
    }
}
