using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bus.dto
{
    public class chitietdoanhthu
    {
        [System.ComponentModel.DisplayName("Tên đoàn du lich")]
        public string tendoan { get; set; }
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tentour { get; set; }
        [System.ComponentModel.DisplayName("Thời điểm")]
        public DateTime thoidiem { get; set; }
        [System.ComponentModel.DisplayName("Giá tour")]
        public decimal gia { get; set; }
        [System.ComponentModel.DisplayName("Số lượng khách hàng")]
        public int soluongkhach { get; set; }
        [System.ComponentModel.DisplayName("Tổng tiền")]
        public decimal tong { get; set; }
        [System.ComponentModel.DisplayName("Tổng chi phí")]
        public decimal tongchiphi { get; set; }
        [System.ComponentModel.DisplayName("Doanh thu")]
        public decimal doanhthu { get; set; }

    }
}
