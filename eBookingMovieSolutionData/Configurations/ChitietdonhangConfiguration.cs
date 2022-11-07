using eBookingMovieSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Configurations
{
    public class ChitietdonhangConfiguration : IEntityTypeConfiguration<Chitietdonhang>
    {
        public void Configure(EntityTypeBuilder<Chitietdonhang> builder)
        {
            builder.ToTable("ChiTietDonHang");

            builder.HasKey(x => new { x.DonhangId, x.VeId });

            builder.HasOne(x => x.Donhang).WithMany(x =>x.Chitietdonhangs).HasForeignKey(x => x.DonhangId);
            builder.HasOne(x => x.Ve).WithMany(x => x.Chitietdonhangs).HasForeignKey(x => x.VeId);
        }
    }
}
