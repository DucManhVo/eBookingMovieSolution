using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Phanloai
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int Sapxep { get; set; }
        public List<PhimInPhanloai> PhimInPhanloai { get; set; }

    }
}
