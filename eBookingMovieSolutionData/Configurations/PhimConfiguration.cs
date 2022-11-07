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
    public class PhimConfiguration : IEntityTypeConfiguration<Phim>
    {
        public void Configure(EntityTypeBuilder<Phim> builder)
        {
            builder.ToTable("Phim");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Soluotxem).HasDefaultValue(0);
        }
    }
}
