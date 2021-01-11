using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Mathang
    {
        public Mathang()
        {
            CtHoadons = new HashSet<CtHoadon>();
            CtPhieudathangs = new HashSet<CtPhieudathang>();
        }

        public string Id { get; set; }
        public string TenMh { get; set; }
        public string DonVi { get; set; }
        public string HinhAnh { get; set; }
        public string MaNcc { get; set; }
        public string MaNhomMh { get; set; }
        public decimal? DonGia { get; set; }
        public bool? IsDeleted { get; set; }
        public string MoTa { get; set; }

        public virtual Nhacungcap MaNccNavigation { get; set; }
        public virtual Nhommathang MaNhomMhNavigation { get; set; }
        public virtual ICollection<CtHoadon> CtHoadons { get; set; }
        public virtual ICollection<CtPhieudathang> CtPhieudathangs { get; set; }
    }
}
