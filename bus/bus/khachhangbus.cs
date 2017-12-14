using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.bus
{
    public class khachhangbus
    {
        public IRepository<khachhang> db;
        public IRepository<gioitinh> db1;
        public khachhangbus()
        {
            db = new GenericRepository<khachhang>();
            db1 = new GenericRepository<gioitinh>();
        }
    }
}
