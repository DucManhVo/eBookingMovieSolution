using Microsoft.EntityFrameworkCore.Design;
using eBookingMovieSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace eBookingMovieSolutionData.EF
{
    public class EBookingMovieSolutionDbContextFactory : IDesignTimeDbContextFactory<EBookingMovieDbContext>
    {
        public EBookingMovieDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("EBookingMovieDb");

            var optionsBuilder = new DbContextOptionsBuilder<EBookingMovieDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EBookingMovieDbContext(optionsBuilder.Options);
        }
    }
}
