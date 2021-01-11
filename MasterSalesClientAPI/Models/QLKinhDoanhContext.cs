using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MasterSalesClientAPI.Models
{
    public partial class QLKinhDoanhContext : DbContext
    {
        public QLKinhDoanhContext()
        {
        }

        public QLKinhDoanhContext(DbContextOptions<QLKinhDoanhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Banglamthem> Banglamthems { get; set; }
        public virtual DbSet<Bangluongtl> Bangluongtls { get; set; }
        public virtual DbSet<Bangthuong> Bangthuongs { get; set; }
        public virtual DbSet<Chucnang> Chucnangs { get; set; }
        public virtual DbSet<Chucvu> Chucvus { get; set; }
        public virtual DbSet<CtBanglamthem> CtBanglamthems { get; set; }
        public virtual DbSet<CtBangluongtl> CtBangluongtls { get; set; }
        public virtual DbSet<CtBangthuong> CtBangthuongs { get; set; }
        public virtual DbSet<CtHoadon> CtHoadons { get; set; }
        public virtual DbSet<CtPhieudathang> CtPhieudathangs { get; set; }
        public virtual DbSet<Danhgiakynang> Danhgiakynangs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Hopdong> Hopdongs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Kynang> Kynangs { get; set; }
        public virtual DbSet<Lichsuchucvu> Lichsuchucvus { get; set; }
        public virtual DbSet<Loaihopdong> Loaihopdongs { get; set; }
        public virtual DbSet<Mathang> Mathangs { get; set; }
        public virtual DbSet<Mucthuong> Mucthuongs { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Nhommathang> Nhommathangs { get; set; }
        public virtual DbSet<Phanquyen> Phanquyens { get; set; }
        public virtual DbSet<Phieudathang> Phieudathangs { get; set; }
        public virtual DbSet<Phongban> Phongbans { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Thamso> Thamsos { get; set; }
        public virtual DbSet<Trinhdo> Trinhdos { get; set; }
        public virtual DbSet<TuVanKh> TuVanKhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=QLKinhDoanh;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Banglamthem>(entity =>
            {
                entity.ToTable("BANGLAMTHEM");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.HeSo).HasColumnType("money");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaTrgPb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaTrgPB");

                entity.Property(e => e.NgayLap).HasColumnType("smalldatetime");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.Banglamthems)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK__BANGLAMTH__MaPho__5AEE82B9");

                entity.HasOne(d => d.MaTrgPbNavigation)
                    .WithMany(p => p.Banglamthems)
                    .HasForeignKey(d => d.MaTrgPb)
                    .HasConstraintName("FK__BANGLAMTH__MaTrg__59063A47");
            });

            modelBuilder.Entity<Bangluongtl>(entity =>
            {
                entity.ToTable("BANGLUONGTL");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaKeToan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLap).HasColumnType("smalldatetime");

                entity.HasOne(d => d.MaKeToanNavigation)
                    .WithMany(p => p.Bangluongtls)
                    .HasForeignKey(d => d.MaKeToan)
                    .HasConstraintName("FK__BANGLUONG__MaKeT__6EF57B66");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.Bangluongtls)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK__BANGLUONG__MaPho__70DDC3D8");
            });

            modelBuilder.Entity<Bangthuong>(entity =>
            {
                entity.ToTable("BANGTHUONG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaPhong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaTrgPb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaTrgPB");

                entity.Property(e => e.NgayLap).HasColumnType("smalldatetime");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.Bangthuongs)
                    .HasForeignKey(d => d.MaPhong)
                    .HasConstraintName("FK__BANGTHUON__MaPho__60A75C0F");

                entity.HasOne(d => d.MaTrgPbNavigation)
                    .WithMany(p => p.Bangthuongs)
                    .HasForeignKey(d => d.MaTrgPb)
                    .HasConstraintName("FK__BANGTHUON__MaTrg__5EBF139D");
            });

            modelBuilder.Entity<Chucnang>(entity =>
            {
                entity.ToTable("CHUCNANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.TenChucNang).HasMaxLength(50);
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.ToTable("CHUCVU");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsTrgPb).HasColumnName("isTrgPB");

                entity.Property(e => e.MaPhongBan)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhuCap).HasColumnType("money");

                entity.Property(e => e.TenChucVu).HasMaxLength(50);

                entity.HasOne(d => d.MaPhongBanNavigation)
                    .WithMany(p => p.Chucvus)
                    .HasForeignKey(d => d.MaPhongBan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CHUCVU__MaPhongB__3D5E1FD2");
            });

            modelBuilder.Entity<CtBanglamthem>(entity =>
            {
                entity.ToTable("CT_BANGLAMTHEM");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaLamThem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.TienLamThem).HasColumnType("money");

                entity.HasOne(d => d.MaLamThemNavigation)
                    .WithMany(p => p.CtBanglamthems)
                    .HasForeignKey(d => d.MaLamThem)
                    .HasConstraintName("FK__CT_BANGLA__MaLam__6383C8BA");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.CtBanglamthems)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__CT_BANGLAM__MaNV__6477ECF3");
            });

            modelBuilder.Entity<CtBangluongtl>(entity =>
            {
                entity.ToTable("CT_BANGLUONGTL");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LuongCb)
                    .HasColumnType("money")
                    .HasColumnName("LuongCB");

                entity.Property(e => e.LuongLamThem).HasColumnType("money");

                entity.Property(e => e.MaLuongTl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaLuongTL");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.PhuCap).HasColumnType("money");

                entity.Property(e => e.TienThuong).HasColumnType("money");

                entity.Property(e => e.TongLuong).HasColumnType("money");

                entity.HasOne(d => d.MaLuongTlNavigation)
                    .WithMany(p => p.CtBangluongtls)
                    .HasForeignKey(d => d.MaLuongTl)
                    .HasConstraintName("FK__CT_BANGLU__MaLuo__73BA3083");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.CtBangluongtls)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__CT_BANGLUO__MaNV__74AE54BC");
            });

            modelBuilder.Entity<CtBangthuong>(entity =>
            {
                entity.ToTable("CT_BANGTHUONG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaMucThuong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaThuong)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TienThuong).HasColumnType("money");

                entity.HasOne(d => d.MaMucThuongNavigation)
                    .WithMany(p => p.CtBangthuongs)
                    .HasForeignKey(d => d.MaMucThuong)
                    .HasConstraintName("FK__CT_BANGTH__MaMuc__6B24EA82");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.CtBangthuongs)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__CT_BANGTHU__MaNV__6A30C649");

                entity.HasOne(d => d.MaThuongNavigation)
                    .WithMany(p => p.CtBangthuongs)
                    .HasForeignKey(d => d.MaThuong)
                    .HasConstraintName("FK__CT_BANGTH__MaThu__693CA210");
            });

            modelBuilder.Entity<CtHoadon>(entity =>
            {
                entity.ToTable("CT_HOADON");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaMH");

                entity.Property(e => e.Slmua).HasColumnName("SLMua");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.CtHoadons)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK__CT_HOADON__MaHD__151B244E");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.CtHoadons)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK__CT_HOADON__MaMH__160F4887");
            });

            modelBuilder.Entity<CtPhieudathang>(entity =>
            {
                entity.ToTable("CT_PHIEUDATHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaMH");

                entity.Property(e => e.MaPhieuDh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaPhieuDH");

                entity.Property(e => e.Sldat).HasColumnName("SLDat");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.CtPhieudathangs)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK__CT_PHIEUDA__MaMH__0D7A0286");

                entity.HasOne(d => d.MaPhieuDhNavigation)
                    .WithMany(p => p.CtPhieudathangs)
                    .HasForeignKey(d => d.MaPhieuDh)
                    .HasConstraintName("FK__CT_PHIEUD__MaPhi__0C85DE4D");
            });

            modelBuilder.Entity<Danhgiakynang>(entity =>
            {
                entity.ToTable("DANHGIAKYNANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LoaiDanhGia).HasMaxLength(50);

                entity.Property(e => e.MaKyNang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.HasOne(d => d.MaKyNangNavigation)
                    .WithMany(p => p.Danhgiakynangs)
                    .HasForeignKey(d => d.MaKyNang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DANHGIAKY__MaKyN__5629CD9C");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Danhgiakynangs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DANHGIAKYN__MaNV__5535A963");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.ToTable("HOADON");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MaPhieuDh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaPhieuDH");

                entity.Property(e => e.NgayLap).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayXuat).HasColumnType("smalldatetime");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__HOADON__MaKH__114A936A");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__HOADON__MaNV__123EB7A3");

                entity.HasOne(d => d.MaPhieuDhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.MaPhieuDh)
                    .HasConstraintName("FK__HOADON__MaPhieuD__10566F31");
            });

            modelBuilder.Entity<Hopdong>(entity =>
            {
                entity.ToTable("HOPDONG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaLoaiHd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaLoaiHD");

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayHD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.MaLoaiHdNavigation)
                    .WithMany(p => p.Hopdongs)
                    .HasForeignKey(d => d.MaLoaiHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOPDONG__MaLoaiH__4D94879B");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Hopdongs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOPDONG__MaNV__4CA06362");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<Kynang>(entity =>
            {
                entity.ToTable("KYNANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.TenKyNang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lichsuchucvu>(entity =>
            {
                entity.ToTable("LICHSUCHUCVU");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaChucVu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayBD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.Lichsuchucvus)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LICHSUCHU__MaChu__46E78A0C");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Lichsuchucvus)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LICHSUCHUC__MaNV__45F365D3");
            });

            modelBuilder.Entity<Loaihopdong>(entity =>
            {
                entity.ToTable("LOAIHOPDONG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Luong).HasColumnType("money");

                entity.Property(e => e.TenLoaiHd)
                    .HasMaxLength(50)
                    .HasColumnName("TenLoaiHD");
            });

            modelBuilder.Entity<Mathang>(entity =>
            {
                entity.ToTable("MATHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.DonVi).HasMaxLength(50);

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.MaNhomMh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNhomMH");

                entity.Property(e => e.MoTa).HasMaxLength(250);

                entity.Property(e => e.TenMh)
                    .HasMaxLength(50)
                    .HasColumnName("TenMH");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK__MATHANG__MaNCC__05D8E0BE");

                entity.HasOne(d => d.MaNhomMhNavigation)
                    .WithMany(p => p.Mathangs)
                    .HasForeignKey(d => d.MaNhomMh)
                    .HasConstraintName("FK__MATHANG__MaNhomM__06CD04F7");
            });

            modelBuilder.Entity<Mucthuong>(entity =>
            {
                entity.ToTable("MUCTHUONG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.TenMucThuong)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TienThuong).HasColumnType("money");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(50)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaChucVu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaTrinhDo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayKetThuc).HasColumnType("smalldatetime");

                entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");

                entity.Property(e => e.NoiSinh).HasMaxLength(50);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NHANVIEN__MaChuc__4222D4EF");

                entity.HasOne(d => d.MaTrinhDoNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.MaTrinhDo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NHANVIEN__MaTrin__412EB0B6");
            });

            modelBuilder.Entity<Nhommathang>(entity =>
            {
                entity.ToTable("NHOMMATHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.TenNhomMh)
                    .HasMaxLength(50)
                    .HasColumnName("TenNhomMH");
            });

            modelBuilder.Entity<Phanquyen>(entity =>
            {
                entity.HasKey(e => new { e.MaChucVu, e.MaChucNang })
                    .HasName("PK__PHANQUYE__BF45491665966BD2");

                entity.ToTable("PHANQUYEN");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaChucNang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.HasOne(d => d.MaChucNangNavigation)
                    .WithMany(p => p.Phanquyens)
                    .HasForeignKey(d => d.MaChucNang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHANQUYEN__MaChu__1DB06A4F");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.Phanquyens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHANQUYEN__MaChu__1EA48E88");
            });

            modelBuilder.Entity<Phieudathang>(entity =>
            {
                entity.ToTable("PHIEUDATHANG");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.DiaChiNhan).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.NgayDat).HasColumnType("smalldatetime");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Phieudathangs)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__PHIEUDATHA__MaKH__09A971A2");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.ToTable("PHONGBAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaTrgPb)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaTrgPB");

                entity.Property(e => e.TenPhong).HasMaxLength(50);

                entity.HasOne(d => d.MaTrgPbNavigation)
                    .WithMany(p => p.Phongbans)
                    .HasForeignKey(d => d.MaTrgPb)
                    .HasConstraintName("FK__PHONGBAN__MaTrgP__4316F928");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.ToTable("TAIKHOAN");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaNV");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Taikhoans)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK__TAIKHOAN__MaNV__1AD3FDA4");
            });

            modelBuilder.Entity<Thamso>(entity =>
            {
                entity.ToTable("THAMSO");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("id");

                entity.Property(e => e.GiaTri).HasColumnType("money");
            });

            modelBuilder.Entity<Trinhdo>(entity =>
            {
                entity.ToTable("TRINHDO");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.TenTrinhDo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TuVanKh>(entity =>
            {
                entity.ToTable("TuVanKH");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.CauHoi).HasMaxLength(1000);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MaKH");

                entity.Property(e => e.NgayDat).HasColumnType("smalldatetime");

                entity.Property(e => e.NgayTraLoi).HasColumnType("smalldatetime");

                entity.Property(e => e.NguoiTraLoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TraLoi).HasMaxLength(1000);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.TuVanKhs)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__TuVanKH__MaKH__00200768");

                entity.HasOne(d => d.NguoiTraLoiNavigation)
                    .WithMany(p => p.TuVanKhs)
                    .HasForeignKey(d => d.NguoiTraLoi)
                    .HasConstraintName("FK__TuVanKH__NguoiTr__01142BA1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
