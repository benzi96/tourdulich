using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.bus
{
    public class phancongbus
    {
        public IRepository<phancong> db;
        public IRepository<nhiemvu> db1;
        public IRepository<nhanvien> db2;
        public IRepository<doandulich> db3;
        public phancongbus()
        {
            db = new GenericRepository<phancong>();
            db1 = new GenericRepository<nhiemvu>();
            db2 = new GenericRepository<nhanvien>();
            db3 = new GenericRepository<doandulich>();
        }
    }
}
