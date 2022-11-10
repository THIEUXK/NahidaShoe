﻿// <auto-generated />
using System;
using A_DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ADAL.Migrations
{
    [DbContext(typeof(NahidaShoesDbContext))]
    [Migration("20221110155843_createdb")]
    partial class createdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("A_DAL.Entities.ChiTietGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("GiaBan")
                        .HasColumnType("real");

                    b.Property<float>("GiaNhap")
                        .HasColumnType("real");

                    b.Property<Guid>("IdChieuCaoDeGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHangGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNsx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChieuCaoDeGiay");

                    b.HasIndex("IdGiay");

                    b.HasIndex("IdHangGiay");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSize");

                    b.HasIndex("IdMauSac", "IdSize", "IdNsx", "IdHangGiay", "IdChieuCaoDeGiay", "IdGiay")
                        .IsUnique();

                    b.ToTable("ChiTietGiay");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietSale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSale")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSale");

                    b.HasIndex("IdChiTietGiay", "IdSale")
                        .IsUnique();

                    b.ToTable("ChiTietSale");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietTheLoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTheLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTheLoai");

                    b.HasIndex("IdChiTietGiay", "IdTheLoai")
                        .IsUnique();

                    b.ToTable("ChiTietTheLoai");
                });

            modelBuilder.Entity("A_DAL.Entities.ChieuCaoDeGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("KichCo")
                        .HasColumnType("int");

                    b.Property<string>("MaKichCo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaKichCo")
                        .IsUnique();

                    b.ToTable("ChieuCaoDeGiay");
                });

            modelBuilder.Entity("A_DAL.Entities.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaChucVu")
                        .IsUnique();

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("A_DAL.Entities.CuaHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaCuaHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenCuaHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaCuaHang")
                        .IsUnique();

                    b.ToTable("CuaHang");
                });

            modelBuilder.Entity("A_DAL.Entities.DiemTieuDung", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaDiemTieuDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("SoDiem")
                        .HasColumnType("real");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang")
                        .IsUnique();

                    b.HasIndex("MaDiemTieuDung")
                        .IsUnique();

                    b.ToTable("DiemTieuDung");
                });

            modelBuilder.Entity("A_DAL.Entities.GiaoCa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChuThich")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaGiaoCa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<float>("TienDuTru")
                        .HasColumnType("real");

                    b.Property<float>("TienLai")
                        .HasColumnType("real");

                    b.Property<float>("TienPhatSinh")
                        .HasColumnType("real");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNhanVien");

                    b.HasIndex("MaGiaoCa")
                        .IsUnique();

                    b.ToTable("GiaoCa");
                });

            modelBuilder.Entity("A_DAL.Entities.Giay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaGiay")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenGiay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaGiay")
                        .IsUnique();

                    b.ToTable("Giay");
                });

            modelBuilder.Entity("A_DAL.Entities.HangGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHangGiay")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenHangGiay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaHangGiay")
                        .IsUnique();

                    b.ToTable("HangGiay");
                });

            modelBuilder.Entity("A_DAL.Entities.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GiamGia")
                        .HasColumnType("real");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHoaDon")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.HasIndex("MaHoaDon")
                        .IsUnique();

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("A_DAL.Entities.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DonGia")
                        .HasColumnType("real");

                    b.Property<Guid>("IdChiTietGiay")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdChiTietGiay", "IdHoaDon")
                        .IsUnique();

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("A_DAL.Entities.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoCCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaKhachHang")
                        .IsUnique();

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Entities.LichSuDiemTieuDung", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("GiaTriQuyDoi")
                        .HasColumnType("real");

                    b.Property<Guid>("IdDiemTieuDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdQuyDoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDiemTieuDung");

                    b.HasIndex("IdQuyDoi");

                    b.HasIndex("IdHoaDon", "IdDiemTieuDung", "IdQuyDoi")
                        .IsUnique();

                    b.ToTable("LichSuDiemTieuDung");
                });

            modelBuilder.Entity("A_DAL.Entities.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenMauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaMauSac")
                        .IsUnique();

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("A_DAL.Entities.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCuaHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdChucVu");

                    b.HasIndex("IdCuaHang");

                    b.HasIndex("MaNhanVien")
                        .IsUnique();

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("A_DAL.Entities.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenNsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaNsx")
                        .IsUnique();

                    b.ToTable("Nsx");
                });

            modelBuilder.Entity("A_DAL.Entities.QuyDoi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("GiaTriQuyDoi")
                        .HasColumnType("real");

                    b.Property<float>("GiaTriSauQuyDoi")
                        .HasColumnType("real");

                    b.Property<string>("MaQuyDoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaQuyDoi")
                        .IsUnique();

                    b.ToTable("QuyDoi");
                });

            modelBuilder.Entity("A_DAL.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LuaChonGiamGia")
                        .HasColumnType("int");

                    b.Property<string>("MaGiamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenChuongTrinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaGiamGia")
                        .IsUnique();

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("A_DAL.Entities.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoSize")
                        .HasColumnType("int");

                    b.Property<string>("TenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaSize")
                        .IsUnique();

                    b.ToTable("Size");
                });

            modelBuilder.Entity("A_DAL.Entities.TheLoai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhanCap")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaTheLoai")
                        .IsUnique();

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietGiay", b =>
                {
                    b.HasOne("A_DAL.Entities.ChieuCaoDeGiay", "IdChieuCaoDeGiayNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdChieuCaoDeGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.Giay", "IdGiayNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.HangGiay", "IdHangGiayNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdHangGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.MauSac", "IdMauSacNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.Nsx", "IdNsxNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdNsx")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.Size", "IdSizeNavigation")
                        .WithMany("ChiTietGiays")
                        .HasForeignKey("IdSize")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdChieuCaoDeGiayNavigation");

                    b.Navigation("IdGiayNavigation");

                    b.Navigation("IdHangGiayNavigation");

                    b.Navigation("IdMauSacNavigation");

                    b.Navigation("IdNsxNavigation");

                    b.Navigation("IdSizeNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietSale", b =>
                {
                    b.HasOne("A_DAL.Entities.ChiTietGiay", "IdChiTietGiayNavigation")
                        .WithMany("ChiTietSales")
                        .HasForeignKey("IdChiTietGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.Sale", "IdSaleNavigation")
                        .WithMany("ChiTietSales")
                        .HasForeignKey("IdSale")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdChiTietGiayNavigation");

                    b.Navigation("IdSaleNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietTheLoai", b =>
                {
                    b.HasOne("A_DAL.Entities.ChiTietGiay", "IdChiTietGiayNavigation")
                        .WithMany("ChiTietTheLoais")
                        .HasForeignKey("IdChiTietGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.TheLoai", "IdTheLoaiNavigation")
                        .WithMany("ChiTietTheLoais")
                        .HasForeignKey("IdTheLoai")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdChiTietGiayNavigation");

                    b.Navigation("IdTheLoaiNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.DiemTieuDung", b =>
                {
                    b.HasOne("A_DAL.Entities.KhachHang", "KhachHang")
                        .WithOne("DiemTieuDung")
                        .HasForeignKey("A_DAL.Entities.DiemTieuDung", "IdKhachHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("A_DAL.Entities.GiaoCa", b =>
                {
                    b.HasOne("A_DAL.Entities.NhanVien", "IdNhanVienNavigation")
                        .WithMany("GiaoCas")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdNhanVienNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.HoaDon", b =>
                {
                    b.HasOne("A_DAL.Entities.KhachHang", "IdKhachHangNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.NhanVien", "IdNhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdKhachHangNavigation");

                    b.Navigation("IdNhanVienNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.HoaDonChiTiet", b =>
                {
                    b.HasOne("A_DAL.Entities.ChiTietGiay", "IdChiTietGiayNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietGiay")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.HoaDon", "IdHoaDonNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdChiTietGiayNavigation");

                    b.Navigation("IdHoaDonNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.LichSuDiemTieuDung", b =>
                {
                    b.HasOne("A_DAL.Entities.DiemTieuDung", "IdDiemTieuDungNavigation")
                        .WithMany("LichSuDiemTieuDungs")
                        .HasForeignKey("IdDiemTieuDung")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.HoaDon", "IdHoaDonNavigation")
                        .WithMany("LichSuDiemTieuDungs")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.QuyDoi", "IdQuyDoiNavigation")
                        .WithMany("LichSuDiemTieuDungs")
                        .HasForeignKey("IdQuyDoi")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdDiemTieuDungNavigation");

                    b.Navigation("IdHoaDonNavigation");

                    b.Navigation("IdQuyDoiNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.NhanVien", b =>
                {
                    b.HasOne("A_DAL.Entities.ChucVu", "IdChucVuNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("A_DAL.Entities.CuaHang", "IdCuaHangNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdCuaHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdChucVuNavigation");

                    b.Navigation("IdCuaHangNavigation");
                });

            modelBuilder.Entity("A_DAL.Entities.ChiTietGiay", b =>
                {
                    b.Navigation("ChiTietSales");

                    b.Navigation("ChiTietTheLoais");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("A_DAL.Entities.ChieuCaoDeGiay", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("A_DAL.Entities.CuaHang", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("A_DAL.Entities.DiemTieuDung", b =>
                {
                    b.Navigation("LichSuDiemTieuDungs");
                });

            modelBuilder.Entity("A_DAL.Entities.Giay", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.HangGiay", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");

                    b.Navigation("LichSuDiemTieuDungs");
                });

            modelBuilder.Entity("A_DAL.Entities.KhachHang", b =>
                {
                    b.Navigation("DiemTieuDung")
                        .IsRequired();

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("A_DAL.Entities.MauSac", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.NhanVien", b =>
                {
                    b.Navigation("GiaoCas");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("A_DAL.Entities.Nsx", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.QuyDoi", b =>
                {
                    b.Navigation("LichSuDiemTieuDungs");
                });

            modelBuilder.Entity("A_DAL.Entities.Sale", b =>
                {
                    b.Navigation("ChiTietSales");
                });

            modelBuilder.Entity("A_DAL.Entities.Size", b =>
                {
                    b.Navigation("ChiTietGiays");
                });

            modelBuilder.Entity("A_DAL.Entities.TheLoai", b =>
                {
                    b.Navigation("ChiTietTheLoais");
                });
#pragma warning restore 612, 618
        }
    }
}