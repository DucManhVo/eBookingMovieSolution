using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Ve
    {
        public int Id { get; set; }
        public int PhimId { get; set; }
        public int GheId { get; set; }
        public decimal Gia { get; set; }
        public decimal Giagoc { get; set; }
        public int Soluong { get; set; }
        public bool Trangthai { get; set; }


        public List<Chitietdonhang> Chitietdonhangs { get; set; }
        public Phim Phim { get; set; }
        public Ghe Ghe { get; set; }

        public List<Giohang> Giohangs { get; set; }
    }
}
