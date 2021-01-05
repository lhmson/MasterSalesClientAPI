using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Loaihopdong
    {
        public Loaihopdong()
        {
            Hopdongs = new HashSet<Hopdong>();
        }

        public string Id { get; set; }
        public string TenLoaiHd { get; set; }
        public int? ThoiHan { get; set; }
        public decimal? Luong { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Hopdong> Hopdongs { get; set; }
    }
}
