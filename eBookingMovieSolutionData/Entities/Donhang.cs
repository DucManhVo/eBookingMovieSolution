using eBookingMovieSolutionData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Donhang
    {
        public int Id { get; set; }
        public DateTime Thoigiantao { set; get; }
        public Guid UserId { set; get; }
        public Status Status { set; get; }

        public List<Chitietdonhang> Chitietdonhangs { get; set; }
        public AppUser AppUser { get; set; }
    }
}
