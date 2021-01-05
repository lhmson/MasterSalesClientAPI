using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class CtBangluongtl
    {
        public string Id { get; set; }
        public string MaLuongTl { get; set; }
        public string MaNv { get; set; }
        public decimal? LuongCb { get; set; }
        public decimal? TienThuong { get; set; }
        public decimal? LuongLamThem { get; set; }
        public decimal? PhuCap { get; set; }
        public decimal? TongLuong { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Bangluongtl MaLuongTlNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
