using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eBookingMovieSolutionData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Configurations
{
    internal class VeConfiguration : IEntityTypeConfiguration<Ve>
    {
        public void Configure(EntityTypeBuilder<Ve> builder)
        {
            builder.ToTable("Ve");
            builder.HasKey(x => new {x.PhimId});
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Gia).IsRequired();
            builder.Property(x => x.Giagoc).IsRequired();
            builder.Property(x => x.Soluong).IsRequired().HasDefaultValue(0);

            builder.HasOne(x => x.Phim).WithMany(x => x.Ves).HasForeignKey(x=> x.PhimId);
            builder.HasOne(x => x.Ghe).WithMany(x => x.Ves).HasForeignKey(x=> x.GheId);
            

        }
    }
}
