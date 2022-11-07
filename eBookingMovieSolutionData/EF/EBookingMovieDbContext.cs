using eBookingMovieSolutionData.Configurations;
using eBookingMovieSolutionData.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.EF
{
    public class EBookingMovieDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public EBookingMovieDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new VeConfiguration());
            modelBuilder.ApplyConfiguration(new LienheConfiguration());
            modelBuilder.ApplyConfiguration(new PhanloaiConfiguration());
            modelBuilder.ApplyConfiguration(new PhimInPhanloaiConfiguration());
            modelBuilder.ApplyConfiguration(new KhuyenmaiConfiguration());
            modelBuilder.ApplyConfiguration(new GheConfiguration());
            modelBuilder.ApplyConfiguration(new PhimConfiguration());
            modelBuilder.ApplyConfiguration(new ChitietdonhangConfiguration());
            modelBuilder.ApplyConfiguration(new DonhangConfiguration());
            modelBuilder.ApplyConfiguration(new ThanhtoanConfiguration());

            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x=> new {x.UserId, x.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x=>x.UserId);

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ve> Ves { get; set; }
        public DbSet<Phanloai> Phanloais { get; set; }
        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        public DbSet<Donhang> Donhangs { get; set; }
        public DbSet<Giohang> Giohangs { get; set; }
        public DbSet<Khuyenmai> Khuyenmais { get; set; }
        public DbSet<Lienhe> Lienhes { get; set; }

        public DbSet<Thanhtoan> Thanhtoans { get; set; }
    }
}
