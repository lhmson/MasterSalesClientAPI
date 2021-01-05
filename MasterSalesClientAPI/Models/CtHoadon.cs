using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class CtHoadon
    {
        public string Id { get; set; }
        public string MaHd { get; set; }
        public string MaMh { get; set; }
        public int? Slmua { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? TongTien { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Hoadon MaHdNavigation { get; set; }
        public virtual Mathang MaMhNavigation { get; set; }
    }
}
