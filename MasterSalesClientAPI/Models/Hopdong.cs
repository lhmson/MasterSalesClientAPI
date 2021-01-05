using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Hopdong
    {
        public string Id { get; set; }
        public string MaNv { get; set; }
        public DateTime? NgayHd { get; set; }
        public DateTime? NgayKt { get; set; }
        public string MaLoaiHd { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Loaihopdong MaLoaiHdNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
