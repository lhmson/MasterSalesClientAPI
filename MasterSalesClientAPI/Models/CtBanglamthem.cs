using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class CtBanglamthem
    {
        public string Id { get; set; }
        public string MaLamThem { get; set; }
        public string MaNv { get; set; }
        public int? SoBuoi { get; set; }
        public decimal? TienLamThem { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Banglamthem MaLamThemNavigation { get; set; }
        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
