using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Nhommathang
    {
        public Nhommathang()
        {
            Mathangs = new HashSet<Mathang>();
        }

        public string Id { get; set; }
        public string TenNhomMh { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Mathang> Mathangs { get; set; }
    }
}
