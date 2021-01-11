using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Bangluongtl
    {
        public Bangluongtl()
        {
            CtBangluongtls = new HashSet<CtBangluongtl>();
        }

        public string Id { get; set; }
        public string MaKeToan { get; set; }
        public DateTime? NgayLap { get; set; }
        public int? Thang { get; set; }
        public string MaPhong { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Nam { get; set; }

        public virtual Nhanvien MaKeToanNavigation { get; set; }
        public virtual Phongban MaPhongNavigation { get; set; }
        public virtual ICollection<CtBangluongtl> CtBangluongtls { get; set; }
    }
}
