using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Taikhoan
    {
        public string Id { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Avatar { get; set; }
        public string MaNv { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Nhanvien MaNvNavigation { get; set; }
    }
}
