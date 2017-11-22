using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace bus.dto
{
    public class giatourdto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tent { get; set; }
        [System.ComponentModel.DisplayName("Giá")]
        public decimal gia { get; set; }
        [System.ComponentModel.DisplayName("Từ ngày")]
        public DateTime tungay { get; set; }
        [System.ComponentModel.DisplayName("Đến ngày")]
        public DateTime denngay { get; set; }

        public giatourdto(giatour o)
        {
            ID = o.id;
            tent = o.tour.tentour;
            gia = (decimal)o.gia;
            tungay = (DateTime)o.tungay;
            denngay = (DateTime)o.denngay;
        }
    }
}
