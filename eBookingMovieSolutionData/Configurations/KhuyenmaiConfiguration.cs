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
    public class KhuyenmaiConfiguration : IEntityTypeConfiguration<Khuyenmai>
    {
        public void Configure(EntityTypeBuilder<Khuyenmai> builder)
        {
            builder.ToTable("KhuyenMai");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Tensukien).IsRequired().HasMaxLength(200);
        }
    }
}
