using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Giohang
    {
        public int Id { get; set; }
        public int VeId { get; set; }
        public int Soluong { get; set; }
        public decimal Gia { get; set; }

        public Guid UserId { get; set; }

        public Ve Ve { get; set; }
        public AppUser AppUser { get; set; }
    }
}
