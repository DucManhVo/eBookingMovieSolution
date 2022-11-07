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
    public class ThanhtoanConfiguration : IEntityTypeConfiguration<Thanhtoan>
    {
        public void Configure(EntityTypeBuilder<Thanhtoan> builder)
        {
            builder.ToTable("Thanhtoans");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Thanhtoans).HasForeignKey(x => x.UserId);
        }
    }
}
