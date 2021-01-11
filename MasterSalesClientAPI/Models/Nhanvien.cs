using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Banglamthems = new HashSet<Banglamthem>();
            Bangluongtls = new HashSet<Bangluongtl>();
            Bangthuongs = new HashSet<Bangthuong>();
            CtBanglamthems = new HashSet<CtBanglamthem>();
            CtBangluongtls = new HashSet<CtBangluongtl>();
            CtBangthuongs = new HashSet<CtBangthuong>();
            Danhgiakynangs = new HashSet<Danhgiakynang>();
            Hoadons = new HashSet<Hoadon>();
            Hopdongs = new HashSet<Hopdong>();
            Lichsuchucvus = new HashSet<Lichsuchucvu>();
            Phongbans = new HashSet<Phongban>();
            Taikhoans = new HashSet<Taikhoan>();
            TuVanKhs = new HashSet<TuVanKh>();
        }

        public string Id { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public string MaTrinhDo { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string MaChucVu { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Chucvu MaChucVuNavigation { get; set; }
        public virtual Trinhdo MaTrinhDoNavigation { get; set; }
        public virtual ICollection<Banglamthem> Banglamthems { get; set; }
        public virtual ICollection<Bangluongtl> Bangluongtls { get; set; }
        public virtual ICollection<Bangthuong> Bangthuongs { get; set; }
        public virtual ICollection<CtBanglamthem> CtBanglamthems { get; set; }
        public virtual ICollection<CtBangluongtl> CtBangluongtls { get; set; }
        public virtual ICollection<CtBangthuong> CtBangthuongs { get; set; }
        public virtual ICollection<Danhgiakynang> Danhgiakynangs { get; set; }
        public virtual ICollection<Hoadon> Hoadons { get; set; }
        public virtual ICollection<Hopdong> Hopdongs { get; set; }
        public virtual ICollection<Lichsuchucvu> Lichsuchucvus { get; set; }
        public virtual ICollection<Phongban> Phongbans { get; set; }
        public virtual ICollection<Taikhoan> Taikhoans { get; set; }
        public virtual ICollection<TuVanKh> TuVanKhs { get; set; }
    }
}
