using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Kynang
    {
        public Kynang()
        {
            Danhgiakynangs = new HashSet<Danhgiakynang>();
        }

        public string Id { get; set; }
        public string TenKyNang { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Danhgiakynang> Danhgiakynangs { get; set; }
    }
}
