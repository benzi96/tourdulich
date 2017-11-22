using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus.dto
{
    public class chitietchiphi
    {
        public string tenchiphi { get; set; }
        public int soluong { get; set; }
        public decimal gia { get; set; }
        public decimal tong { get; set; }

        public chitietchiphi(chitietthanhtoan ct)
        {
            tenchiphi = ct.tenchiphi;
            soluong = (int)ct.soluong;
            gia = (decimal)ct.gia;
            tong = soluong * gia;
        }
    }
}
