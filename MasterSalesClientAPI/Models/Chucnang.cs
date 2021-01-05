using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Chucnang
    {
        public Chucnang()
        {
            Phanquyens = new HashSet<Phanquyen>();
        }

        public string Id { get; set; }
        public string TenChucNang { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Phanquyen> Phanquyens { get; set; }
    }
}
