using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class CtBangthuong
    {
        public string Id { get; set; }
        public string MaThuong { get; set; }
        public string MaNv { get; set; }
        public string MaMucThuong { get; set; }
        public decimal? TienThuong { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Mucthuong MaMucThuongNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
        public virtual Bangthuong MaThuongNavigation { get; set; }
    }
}
