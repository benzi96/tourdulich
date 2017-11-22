using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace bus.bus
{
    public class phieuthanhtoanbus
    {
        public IRepository<phieuthanhtoan> db;
        public IRepository<doandulich> db1;
        public IRepository<loaiphieu> db2;
        public phieuthanhtoanbus()
        {
            db = new GenericRepository<phieuthanhtoan>();
            db1 = new GenericRepository<doandulich>();
            db2 = new GenericRepository<loaiphieu>();
        }

        public List<loaiphieu> listnew()
        {
            loaiphieu lp = new loaiphieu();
            lp.id = 5;
            lp.tenloaiphieu = "Tổng chi phí";
            var loaiphieus = db2.GetAll().ToList();
            loaiphieus.Add(lp);
            return loaiphieus;
        }
        public bool add(phieuthanhtoan ptt)
        {
            int i = 1;
            foreach (chitietthanhtoan ct in ptt.chitietthanhtoan)
            {
                ct.idchitiet = i;
                i++;
            }
            return db.Add(ptt);
        }
        public bool update(phieuthanhtoan ptt)
        {
            return db.Update(ptt);
        }
    }
}
