using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.dto;

namespace Core.bus
{
    public class thongkechiphibus
    {
        IRepository<chitietthanhtoan> db;
        public thongkechiphibus()
        {
            db = new GenericRepository<chitietthanhtoan>();
        }

        public List<chitietchiphi> chiphi(int iddoandulich, int i)
        {
            return db.Find(c => c.phieuthanhtoan.doandulich.id == iddoandulich && c.phieuthanhtoan.idloaiphieu == i)
                     .AsEnumerable()
                     .Select(c=>new chitietchiphi(c))
                     .ToList();
        }
        public List<chitietchiphi> chiphi(int iddoandulich)
        {
            return db.Find(c => c.phieuthanhtoan.doandulich.id == iddoandulich).OrderBy(c => c.phieuthanhtoan.loaiphieu)
                     .AsEnumerable()
                     .Select(c => new chitietchiphi(c)).ToList();
        }

        public decimal tongchiphi(int iddoandulich)
        {
            return (decimal)db.Find(c => c.phieuthanhtoan.doandulich.id == iddoandulich).Sum(c => c.soluong * c.gia);
        }

        public decimal tongchiphi(IEnumerable<doandulich> ddls)
        {
            decimal tong = 0;
            foreach(doandulich ddl in ddls)
            {
                tong += tongchiphi(ddl.id);
            }
            return tong;
        }
    }
}
