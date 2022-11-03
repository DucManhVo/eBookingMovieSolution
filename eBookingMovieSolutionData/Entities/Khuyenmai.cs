using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Khuyenmai
    {
        public int Id { get; set; }
        public int Tensukien { get; set; }
        public int Ngaybatdau { get; set; }
        public int Ngayketthuc { get; set; } 
        public int Tylekhuyenmai { get; set; }
        public int Giatrikhuyenmai { get; set; }
        public int VeId { get; set; }
        public int PhanloaiId { get; set; }
    }
}
