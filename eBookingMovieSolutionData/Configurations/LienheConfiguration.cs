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
    public class LienheConfiguration : IEntityTypeConfiguration<Lienhe>
    {
        public void Configure(EntityTypeBuilder<Lienhe> builder)
        {
            builder.ToTable("LienHe");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Ten).HasMaxLength(200).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Sodienthoai).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Tinnhan).IsRequired();
        }
    }
}
