using Core;

namespace Core.dto
{
    public class tourdto
    {
        public int ID { get; set; }
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tent { get; set; }
        [System.ComponentModel.DisplayName("Đặc điểm")]
        public string dacdiem { get; set; }
        [System.ComponentModel.DisplayName("Loại hình du lịch")]
        public string tenlh { get; set; }

        public tourdto(tour o)
        {
            ID = o.id;
            dacdiem = o.dacdiem;
            tent = o.tentour;
            tenlh = o.loaihinhdulich.tenloaihinh;
        }
    }
}
