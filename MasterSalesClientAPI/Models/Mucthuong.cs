using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Mucthuong
    {
        public Mucthuong()
        {
            CtBangthuongs = new HashSet<CtBangthuong>();
        }

        public string Id { get; set; }
        public string TenMucThuong { get; set; }
        public decimal? TienThuong { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<CtBangthuong> CtBangthuongs { get; set; }
    }
}
