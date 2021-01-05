using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Phanquyen
    {
        public string MaChucNang { get; set; }
        public string MaChucVu { get; set; }
        public string GhiChu { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Chucnang MaChucNangNavigation { get; set; }
        public virtual Chucvu MaChucVuNavigation { get; set; }
    }
}
