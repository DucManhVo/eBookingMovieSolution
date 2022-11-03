using eBookingMovieSolutionData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.EF
{
    internal class EBookingMovieDbContext : DbContext
    {
        public EBookingMovieDbContext(DbContextOptions options) : base(options)
        {
        }

        
    }
}
