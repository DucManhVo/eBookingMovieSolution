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
    public class PhanloaiConfiguration : IEntityTypeConfiguration<Phanloai>
    {
        public void Configure(EntityTypeBuilder<Phanloai> builder)
        {
            builder.ToTable("PhanLoai");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
        }
    }
}
