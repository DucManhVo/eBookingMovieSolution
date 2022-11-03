using eBookingMovieSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.EF
{
    internal class EBookingMovieDbContext : DbContext
    {
        public EBookingMovieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Ve> Ves { get; set; }
        public DbSet<Phanloai> Phanloais { get; set; }
        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        public DbSet<Donhang> Donhangs { get; set; }
        public DbSet<Giohang> Giohangs { get; set; }
        public DbSet<Khuyenmai> Khuyenmais { get; set; }
        public DbSet<Lienhe> Lienhes { get; set; }
    }
}
