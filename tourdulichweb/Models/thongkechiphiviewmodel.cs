using bus.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tourdulichweb.Models
{
    public class thongkechiphiviewmodel
    {
        public string tenloaiphieu { get; set; }
        public List<chitietchiphi> ctcps { get; set; }
        public decimal tong { get; set; }

        public thongkechiphiviewmodel(List<chitietchiphi> cts, int i)
        {
            ctcps = cts;
            switch (i)
            {
                case 1: tenloaiphieu = "Phiếu thanh toán cho khách sạn"; break;
                case 2: tenloaiphieu = "Phiếu thanh toán cho các bữa ăn"; break;
                case 3: tenloaiphieu = "Phiếu thanh toán cho các phương tiện"; break;
                case 4: tenloaiphieu = "Phiếu thanh toán cho chi phí khác"; break;
                case 5: tenloaiphieu = "Tổng các chi phí"; break;
            }
            tong = 0;
            foreach(chitietchiphi ct in ctcps)
            {
                tong += ct.tong;
            }
        }
    }
}