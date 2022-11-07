using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace eBookingMovieSolutionData.Entities
{
    public class Thanhtoan 
    {
        public int Id { set; get; }
        public DateTime Ngaythanhtoan { set; get; }
        public string ExternalThanhtoanId { set; get; }
        public decimal Soluong { set; get; }
        public decimal Phi { set; get; }
        public string Ketqua { set; get; }
        public string Thongbao { set; get; }
        public TransactionStatus Status { set; get; }
        

        public Guid UserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
