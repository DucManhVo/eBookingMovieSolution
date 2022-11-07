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
    internal class GiohangConfiguration : IEntityTypeConfiguration<Giohang>
    {
        public void Configure(EntityTypeBuilder<Giohang> builder)
        {
            builder.ToTable("GioHang");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.Ve).WithMany(x => x.Giohangs).HasForeignKey(x => x.VeId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Giohangs).HasForeignKey(x => x.UserId);  
        }
    }
}
