using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Lichsuchucvu
    {
        public string Id { get; set; }
        public string MaNv { get; set; }
        public string MaChucVu { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Chucvu MaChucVuNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
