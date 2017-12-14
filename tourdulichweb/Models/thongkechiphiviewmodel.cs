using Core.dto;
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
        public string tong { get; set; }

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
            decimal tongs = 0;
            if (cts != null)
            {
                foreach (chitietchiphi ct in ctcps)
                {
                    tongs += ct.tongs;
                }
            }
            tong = String.Format("{0:C}", tongs);
        }
    }
}