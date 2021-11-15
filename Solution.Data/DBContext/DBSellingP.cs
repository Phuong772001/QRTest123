using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellingPhone.Aplication.Entities;
using Solution.Data.Entities;

namespace SellingPhone.Aplication.DBContext
{
    class DBSellingP : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DQV6D76\\SQLEXPRESS;Initial Catalog=DuAn1_Phuong;User ID=sa;Password=123456");
            }
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<DoPhanGiai> DoPhanGiais { get; set; }
        public DbSet<Bonho> Bonhos { get; set; }
        public DbSet<HangDT> HangDts { get; set; }
        public DbSet<Lichsu> Lichsus { get; set; }
        public DbSet<Hedieuhanh> Hedieuhanhs { get; set; }
        public DbSet<Mausac> Mausacs { get; set; }
        public DbSet<Sanpham> Sanphams { get; set; }
        public DbSet<Quocgia> Quocgias { get; set; }
        public DbSet<Chitietsanpham> Chitietsanphams { get; set; }
        public DbSet<Chitiethoadon> Chitiethoadons { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Nhanvien>(table =>
            {
                table.HasKey(x => x.IdNhanVien);

                table.HasOne(x => x.Roles)
                    .WithMany(x => x.Nhanviens)
                    .HasForeignKey(x => x.IDRole)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Chitietsanpham>(table =>
            {
                table.HasKey(x => new
                {
                    x.IDBonho,
                    x.IDChitietsp,
                    x.IDDophangiai,
                    x.IDHedieuhanh,
                    x.IDMausac,
                    x.IDSanPham,
                    x.IDQuocgia,
                });

                table.HasOne(x => x.Bonhos)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDBonho)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.Sanphams)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDSanPham)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.DoPhanGiais)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDDophangiai)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.Hedieuhanhs)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDHedieuhanh)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.Mausacs)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDMausac)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.Quocgias)
                    .WithMany(x => x.Chitietsanphams)
                    .HasForeignKey(x => x.IDQuocgia)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);

            });
            builder.Entity<Chitiethoadon>(table =>
            {
                table.HasKey(x => x.ID);

                table.HasOne(x => x.Chitietsanphams)
                    .WithMany(x => x.Chitiethoadons)
                    .HasForeignKey(x => x.Idchitiet)
                    .HasPrincipalKey(x => x.IDChitietsp)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.HoaDons)
                    .WithMany(x => x.Chitiethoadons)
                    .HasForeignKey(x => x.MaHD)
                    .HasPrincipalKey(x => x.MaHD)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<Sanpham>(table =>
            {
                table.HasKey(x => x.Id);

                table.HasOne(x => x.HangDts)
                    .WithMany(x => x.Sanphams)
                    .HasForeignKey(x => x.IdHang)
                    .HasPrincipalKey(x => x.Id)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            builder.Entity<HoaDon>(table =>
            {
                table.HasKey(x => x.MaHD);

                table.HasOne(x => x.Khachhangs)
                    .WithMany(x => x.HoaDons)
                    .HasForeignKey(x => x.IdKhachhang)
                    .HasPrincipalKey(x => x.MaKH)
                    .OnDelete(DeleteBehavior.Cascade);
                table.HasOne(x => x.Nhanviens)
                    .WithMany(x => x.HoaDons)
                    .HasForeignKey(x => x.IdnhanVien)
                    .HasPrincipalKey(x => x.IdNhanVien)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}
