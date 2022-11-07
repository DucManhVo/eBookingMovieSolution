using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Phim
    {
        public int Id { get; set; }
        public string Anh { get; set; }
        public string Tenphim { get; set; }
        public DateTime Ngayphathanh { get; set; }
        public int Soluotxem { get; set; }

        public List<PhimInPhanloai> PhimInPhanloai { get; set; }
        public List<Ve> Ves { get; set; }

    }
}
