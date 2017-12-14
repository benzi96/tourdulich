using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.dto
{
    public class tinhhinhhoatdongcuatour
    {
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tentour { get; set; }
        [System.ComponentModel.DisplayName("Số lượng đoàn du lịch")]
        public int soluongdoandulich { get; set; }
        [System.ComponentModel.DisplayName("Tổng tiền")]
        public decimal tong { get; set; }
        [System.ComponentModel.DisplayName("Tổng chi phí")]
        public decimal tongchiphi { get; set; }
        [System.ComponentModel.DisplayName("Tổng doanh thu")]
        public decimal tongdoanhthu { get; set; }
    }
}
