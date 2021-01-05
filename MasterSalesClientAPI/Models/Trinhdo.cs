using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Trinhdo
    {
        public Trinhdo()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public string Id { get; set; }
        public string TenTrinhDo { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
