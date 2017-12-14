using Core.dto;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.bus
{
    public class doandulichbus
    {
        public IRepository<doandulich> db;
        public IRepository<tour> db1;
        public IRepository<khachhang> db2;
        public doandulichbus()
        {
            db = new GenericRepository<doandulich>();
            db1 = new GenericRepository<tour>();
            db2 = new GenericRepository<khachhang>();
        }
        public List<nguoidto> listkh()
        {
            return db2.GetAll().Select(c => new nguoidto(c)).ToList();
        }
        public bool add(doandulich ddl)
        {
            //kiem tra khach hang

            return db.Add(ddl);
        }

        public bool update(doandulich ddl, chitietdoandulich[] ct)
        {
            //xoa chitiet cu
            //add chi tiet moi
            return db.Update(ddl);
        }
    }
}
