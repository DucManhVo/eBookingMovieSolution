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
    public class PhimInPhanloaiConfiguration : IEntityTypeConfiguration<PhimInPhanloai>
    {
        public void Configure(EntityTypeBuilder<PhimInPhanloai> builder)
        {
            builder.HasKey(x => new { x.PhimId, x.PhanloaiId });
            builder.ToTable("PhimInPhanloai");
            builder.HasOne(x => x.Phim).WithMany(x => x.PhimInPhanloai).HasForeignKey(x => x.PhimId);
            builder.HasOne(x => x.Phanloai).WithMany(x => x.PhimInPhanloai).HasForeignKey(x => x.PhanloaiId);
        }
    }
}
