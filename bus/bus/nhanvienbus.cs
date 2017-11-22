using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace bus.bus
{
    public class nhanvienbus
    {
        public IRepository<nhanvien> db;
        public IRepository<gioitinh> db1;
        public nhanvienbus()
        {
            db = new GenericRepository<nhanvien>();
            db1 = new GenericRepository<gioitinh>();
        }
    }
}
