﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eBookingMovieSolutionData.EF;

#nullable disable

namespace eBookingMovieSolutionData.Migrations
{
    [DbContext(typeof(EBookingMovieDbContext))]
    [Migration("20221107220715_AspNetCoreIdentityDatabase2")]
    partial class AspNetCoreIdentityDatabase2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Chitietdonhang", b =>
                {
                    b.Property<int>("DonhangId")
                        .HasColumnType("int");

                    b.Property<int>("VeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("DonhangId", "VeId");

                    b.HasIndex("VeId");

                    b.ToTable("ChiTietDonHang", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Donhang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Thoigiantao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DonHang", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Ghe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Loaighe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soghe")
                        .HasColumnType("int");

                    b.Property<DateTime>("Thoigian")
                        .HasColumnType("datetime2");

                    b.Property<int>("Trangthai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Ghe", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Giohang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("VeId");

                    b.ToTable("Giohangs");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Khuyenmai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Giatrikhuyenmai")
                        .HasColumnType("int");

                    b.Property<int>("Ngaybatdau")
                        .HasColumnType("int");

                    b.Property<int>("Ngayketthuc")
                        .HasColumnType("int");

                    b.Property<int>("PhanloaiId")
                        .HasColumnType("int");

                    b.Property<int>("Tensukien")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("Tylekhuyenmai")
                        .HasColumnType("int");

                    b.Property<int>("VeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Lienhe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Sodienthoai")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Tinnhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LienHe", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Phanloai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Sapxep")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("PhanLoai", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Phim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngayphathanh")
                        .HasColumnType("datetime2");

                    b.Property<int>("Soluotxem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Tenphim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Phim", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.PhimInPhanloai", b =>
                {
                    b.Property<int>("PhimId")
                        .HasColumnType("int");

                    b.Property<int>("PhanloaiId")
                        .HasColumnType("int");

                    b.HasKey("PhimId", "PhanloaiId");

                    b.HasIndex("PhanloaiId");

                    b.ToTable("PhimInPhanloai", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Thanhtoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ExternalThanhtoanId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ketqua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaythanhtoan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Phi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Soluong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Thongbao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Thanhtoans", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Ve", b =>
                {
                    b.Property<int>("PhimId")
                        .HasColumnType("int");

                    b.Property<int>("GheId")
                        .HasColumnType("int");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Giagoc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Soluong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("Trangthai")
                        .HasColumnType("bit");

                    b.HasKey("PhimId");

                    b.HasIndex("GheId");

                    b.ToTable("Ve", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Chitietdonhang", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.Donhang", "Donhang")
                        .WithMany("Chitietdonhangs")
                        .HasForeignKey("DonhangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBookingMovieSolutionData.Entities.Ve", "Ve")
                        .WithMany("Chitietdonhangs")
                        .HasForeignKey("VeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Donhang");

                    b.Navigation("Ve");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Donhang", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.AppUser", "AppUser")
                        .WithMany("Donhangs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Giohang", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.AppUser", "AppUser")
                        .WithMany("Giohangs")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBookingMovieSolutionData.Entities.Ve", "Ve")
                        .WithMany("Giohangs")
                        .HasForeignKey("VeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Ve");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.PhimInPhanloai", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.Phanloai", "Phanloai")
                        .WithMany("PhimInPhanloai")
                        .HasForeignKey("PhanloaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBookingMovieSolutionData.Entities.Phim", "Phim")
                        .WithMany("PhimInPhanloai")
                        .HasForeignKey("PhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phanloai");

                    b.Navigation("Phim");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Thanhtoan", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.AppUser", "AppUser")
                        .WithMany("Thanhtoans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Ve", b =>
                {
                    b.HasOne("eBookingMovieSolutionData.Entities.Ghe", "Ghe")
                        .WithMany("Ves")
                        .HasForeignKey("GheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBookingMovieSolutionData.Entities.Phim", "Phim")
                        .WithMany("Ves")
                        .HasForeignKey("PhimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ghe");

                    b.Navigation("Phim");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.AppUser", b =>
                {
                    b.Navigation("Donhangs");

                    b.Navigation("Giohangs");

                    b.Navigation("Thanhtoans");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Donhang", b =>
                {
                    b.Navigation("Chitietdonhangs");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Ghe", b =>
                {
                    b.Navigation("Ves");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Phanloai", b =>
                {
                    b.Navigation("PhimInPhanloai");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Phim", b =>
                {
                    b.Navigation("PhimInPhanloai");

                    b.Navigation("Ves");
                });

            modelBuilder.Entity("eBookingMovieSolutionData.Entities.Ve", b =>
                {
                    b.Navigation("Chitietdonhangs");

                    b.Navigation("Giohangs");
                });
#pragma warning restore 612, 618
        }
    }
}
