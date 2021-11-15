﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SellingPhone.Aplication.DBContext;

namespace Solution.Data.Migrations
{
    [DbContext(typeof(DBSellingP))]
    partial class DBSellingPModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Bonho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bonhos");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Chitietsanpham", b =>
                {
                    b.Property<int>("IDBonho")
                        .HasColumnType("int");

                    b.Property<int>("IDChitietsp")
                        .HasColumnType("int");

                    b.Property<int>("IDDophangiai")
                        .HasColumnType("int");

                    b.Property<int>("IDHedieuhanh")
                        .HasColumnType("int");

                    b.Property<int>("IDMausac")
                        .HasColumnType("int");

                    b.Property<int>("IDSanPham")
                        .HasColumnType("int");

                    b.Property<int>("IDQuocgia")
                        .HasColumnType("int");

                    b.Property<float>("Gia")
                        .HasColumnType("real");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("IDBonho", "IDChitietsp", "IDDophangiai", "IDHedieuhanh", "IDMausac", "IDSanPham", "IDQuocgia");

                    b.HasIndex("IDDophangiai");

                    b.HasIndex("IDHedieuhanh");

                    b.HasIndex("IDMausac");

                    b.HasIndex("IDQuocgia");

                    b.HasIndex("IDSanPham");

                    b.ToTable("Chitietsanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.DoPhanGiai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DoPhanGiais");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.HangDT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangDTs");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Hedieuhanh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hedieuhanhs");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Mausac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mausacs");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Nhanvien", b =>
                {
                    b.Property<int>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Hinhanh")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IDRole")
                        .HasColumnType("int");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("IdNhanVien");

                    b.HasIndex("IDRole");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Sanpham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("Hinhanh")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IdHang")
                        .HasColumnType("int");

                    b.Property<string>("Imei")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdHang");

                    b.ToTable("Sanphams");
                });

            modelBuilder.Entity("Solution.Data.Entities.Chitiethoadon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Dongiaban")
                        .HasColumnType("int");

                    b.Property<int>("Idchitiet")
                        .HasColumnType("int");

                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<float>("Tongtien")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("Idchitiet");

                    b.HasIndex("MaHD");

                    b.ToTable("Chitiethoadons");
                });

            modelBuilder.Entity("Solution.Data.Entities.HoaDon", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdKhachhang")
                        .HasColumnType("int");

                    b.Property<int>("IdnhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaylaphoadon")
                        .HasColumnType("datetime2");

                    b.HasKey("MaHD");

                    b.HasIndex("IdKhachhang");

                    b.HasIndex("IdnhanVien");

                    b.ToTable("Hoadons");
                });

            modelBuilder.Entity("Solution.Data.Entities.Khachhang", b =>
                {
                    b.Property<int>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKH");

                    b.ToTable("Khachhangs");
                });

            modelBuilder.Entity("Solution.Data.Entities.Lichsu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoigianBatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoigianketT")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenNV")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Lichsus");
                });

            modelBuilder.Entity("Solution.Data.Entities.Quocgia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quocgias");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Chitietsanpham", b =>
                {
                    b.HasOne("SellingPhone.Aplication.Entities.Bonho", "Bonhos")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDBonho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingPhone.Aplication.Entities.DoPhanGiai", "DoPhanGiais")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDDophangiai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingPhone.Aplication.Entities.Hedieuhanh", "Hedieuhanhs")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDHedieuhanh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingPhone.Aplication.Entities.Mausac", "Mausacs")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDMausac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Solution.Data.Entities.Quocgia", "Quocgias")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDQuocgia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingPhone.Aplication.Entities.Sanpham", "Sanphams")
                        .WithMany("Chitietsanphams")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bonhos");

                    b.Navigation("DoPhanGiais");

                    b.Navigation("Hedieuhanhs");

                    b.Navigation("Mausacs");

                    b.Navigation("Quocgias");

                    b.Navigation("Sanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Nhanvien", b =>
                {
                    b.HasOne("SellingPhone.Aplication.Entities.Role", "Roles")
                        .WithMany("Nhanviens")
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Sanpham", b =>
                {
                    b.HasOne("SellingPhone.Aplication.Entities.HangDT", "HangDts")
                        .WithMany("Sanphams")
                        .HasForeignKey("IdHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangDts");
                });

            modelBuilder.Entity("Solution.Data.Entities.Chitiethoadon", b =>
                {
                    b.HasOne("SellingPhone.Aplication.Entities.Chitietsanpham", "Chitietsanphams")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("Idchitiet")
                        .HasPrincipalKey("IDChitietsp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Solution.Data.Entities.HoaDon", "HoaDons")
                        .WithMany("Chitiethoadons")
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Chitietsanphams");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Solution.Data.Entities.HoaDon", b =>
                {
                    b.HasOne("Solution.Data.Entities.Khachhang", "Khachhangs")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachhang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SellingPhone.Aplication.Entities.Nhanvien", "Nhanviens")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdnhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khachhangs");

                    b.Navigation("Nhanviens");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Bonho", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Chitietsanpham", b =>
                {
                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.DoPhanGiai", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.HangDT", b =>
                {
                    b.Navigation("Sanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Hedieuhanh", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Mausac", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Nhanvien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Role", b =>
                {
                    b.Navigation("Nhanviens");
                });

            modelBuilder.Entity("SellingPhone.Aplication.Entities.Sanpham", b =>
                {
                    b.Navigation("Chitietsanphams");
                });

            modelBuilder.Entity("Solution.Data.Entities.HoaDon", b =>
                {
                    b.Navigation("Chitiethoadons");
                });

            modelBuilder.Entity("Solution.Data.Entities.Khachhang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Solution.Data.Entities.Quocgia", b =>
                {
                    b.Navigation("Chitietsanphams");
                });
#pragma warning restore 612, 618
        }
    }
}
