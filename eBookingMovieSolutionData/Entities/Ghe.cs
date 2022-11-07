using eBookingMovieSolutionData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookingMovieSolutionData.Entities
{
    public class Ghe
    {
        public int Id { get; set; }
        public string Loaighe { get; set; }
        public int Soghe { get; set; }
        public DateTime Thoigian { get; set; }
        public Status Trangthai { get; set; }
        public List<Ve> Ves { get; set; }


    }
}
