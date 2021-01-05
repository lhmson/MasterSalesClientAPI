using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class CtPhieudathang
    {
        public string Id { get; set; }
        public string MaPhieuDh { get; set; }
        public string MaMh { get; set; }
        public int? Sldat { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? TongTien { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Mathang MaMhNavigation { get; set; }
        public virtual Phieudathang MaPhieuDhNavigation { get; set; }
    }
}
