using System;
using System.Collections.Generic;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class Phongban
    {
        public Phongban()
        {
            Banglamthems = new HashSet<Banglamthem>();
            Bangluongtls = new HashSet<Bangluongtl>();
            Bangthuongs = new HashSet<Bangthuong>();
            Chucvus = new HashSet<Chucvu>();
        }

        public string Id { get; set; }
        public string TenPhong { get; set; }
        public string MaTrgPb { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Nhanvien MaTrgPbNavigation { get; set; }
        public virtual ICollection<Banglamthem> Banglamthems { get; set; }
        public virtual ICollection<Bangluongtl> Bangluongtls { get; set; }
        public virtual ICollection<Bangthuong> Bangthuongs { get; set; }
        public virtual ICollection<Chucvu> Chucvus { get; set; }
    }
}
