using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.dto
{
    public class chitietdiemthamquandto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tent { get; set; }
        [System.ComponentModel.DisplayName("Tên địa điểm")]
        public string tendd { get; set; }

        public chitietdiemthamquandto(chitietdiemthamquan o)
        {
            ID = o.id;
            tent = o.tour.tentour;
            tendd = o.diadiem.tendiadiem;
        }
    }
}
