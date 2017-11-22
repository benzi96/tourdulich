using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace bus.dto
{
    public class diadiemdto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Tên địa điểm")]
        public string tendd { get; set; }
        [System.ComponentModel.DisplayName("Tên tỉnh thành")]
        public string tentt { get; set; }

        public diadiemdto(diadiem o)
        {
            ID = o.id;
            tendd = o.tendiadiem;
            tentt = o.tinhthanh.tentt;
        }
    }
}
