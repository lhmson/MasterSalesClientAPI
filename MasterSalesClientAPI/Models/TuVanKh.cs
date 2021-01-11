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
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayTraLoi { get; set; }
        public string NguoiTraLoi { get; set; }

        public virtual Khachhang MaKhNavigation { get; set; }
        public virtual Nhanvien NguoiTraLoiNavigation { get; set; }
    }
}
