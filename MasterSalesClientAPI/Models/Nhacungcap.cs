using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            Mathangs = new HashSet<Mathang>();
        }

        public string Id { get; set; }
        public string TenNcc { get; set; }
        public string Sdt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Mathang> Mathangs { get; set; }
    }
}
