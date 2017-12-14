using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
    public class loaihinhdulichdto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Tên loại hình du lịch")]
        public string tenlh { get; set; }

        public loaihinhdulichdto(loaihinhdulich o)
        {
            ID = o.id;
            tenlh = o.tenloaihinh;
        }
    }
}
