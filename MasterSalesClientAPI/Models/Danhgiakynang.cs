using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Danhgiakynang
    {
        public string Id { get; set; }
        public string MaNv { get; set; }
        public string MaKyNang { get; set; }
        public string LoaiDanhGia { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Kynang MaKyNangNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
