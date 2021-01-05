using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class TuVanKh
    {
        public string Id { get; set; }
        public string MaKh { get; set; }
        public string CauHoi { get; set; }
        public string TraLoi { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
    }
}
