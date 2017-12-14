using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
    public class chitietchiphi
    {
        public string tenchiphi { get; set; }
        public int soluong { get; set; }
        public string gia { get; set; }
        public decimal tongs { get; set; }
        public string tong { get; set; }
        public DateTime ngay { get; set; }
        public chitietchiphi(chitietthanhtoan ct)
        {
            tenchiphi = ct.tenchiphi;
            soluong = (int)ct.soluong;
            gia = String.Format("{0:C}", ct.gia);
            tongs = soluong * (decimal)ct.gia;
            tong = String.Format("{0:C}", tongs);
            ngay = (DateTime)ct.phieuthanhtoan.ngaytao;
        }
    }
}
