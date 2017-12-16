using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core.bus
{
    public class phieuthanhtoanbus
    {
        public IRepository<phieuthanhtoan> db;
        public IRepository<doandulich> db1;
        public IRepository<loaiphieu> db2;
        public IRepository<chitietthanhtoan> db3;
        public phieuthanhtoanbus()
        {
            db = new GenericRepository<phieuthanhtoan>();
            db1 = new GenericRepository<doandulich>();
            db2 = new GenericRepository<loaiphieu>();
            db3 = new GenericRepository<chitietthanhtoan>();
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
        public bool update(phieuthanhtoan ptt, chitietthanhtoan[] cttt)
        {
            List<chitietthanhtoan> ctttcu = db3.Find(c => c.idphieuthanhtoan == ptt.id).ToList();
            foreach(chitietthanhtoan ct in ctttcu)
            {
                db3.Delete(ct);
            }
            int i = 1;
            foreach (chitietthanhtoan ct in cttt)
            {
                ct.idphieuthanhtoan = ptt.id;
                ct.idchitiet = i;
                i++;
                db3.Add(ct);
            }
            return db.Update(ptt);
        }
    }
}
