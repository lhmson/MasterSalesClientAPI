﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Banglamthem
    {
        public Banglamthem()
        {
            CtBanglamthems = new HashSet<CtBanglamthem>();
        }

        public string Id { get; set; }
        public string MaTrgPb { get; set; }
        public DateTime? NgayLap { get; set; }
        public int Thang { get; set; }
        public string MaPhong { get; set; }
        public decimal? HeSo { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Nam { get; set; }

        public virtual Phongban MaPhongNavigation { get; set; }
        public virtual Nhanvien MaTrgPbNavigation { get; set; }
        public virtual ICollection<CtBanglamthem> CtBanglamthems { get; set; }
    }
}
