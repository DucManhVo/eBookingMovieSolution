using eBookingMovieSolutionData.Entities;
using eBookingMovieSolutionData.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Configurations
{
    public class GheConfiguration : IEntityTypeConfiguration<Ghe>
    {
        public void Configure(EntityTypeBuilder<Ghe> builder)
        {
            builder.ToTable("Ghe");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Soghe).IsRequired();
            builder.Property(x => x.Loaighe).IsRequired();
            builder.Property(x => x.Trangthai).HasDefaultValue(Status.InActive);

            
        }
    }
}
