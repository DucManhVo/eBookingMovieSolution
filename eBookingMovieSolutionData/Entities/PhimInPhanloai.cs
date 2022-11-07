using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class PhimInPhanloai
    {
        public int PhimId { get; set; }
        public Phim Phim { get; set; }
        public int PhanloaiId { get; set; }
        public Phanloai Phanloai { get; set; }
    }
}
