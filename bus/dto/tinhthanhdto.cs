using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus.dto
{
    public class tinhthanhdto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Mã tỉnh thành")]
        public string matt { get; set; }
        [System.ComponentModel.DisplayName("Tên tỉnh thành")]
        public string tentt { get; set; }

        public tinhthanhdto(tinhthanh o)
        {
            ID = o.id;
            matt = o.matt;
            tentt = o.tentt;
        }
    }
}
