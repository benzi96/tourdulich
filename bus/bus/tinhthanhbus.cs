using Core.dto;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.bus
{
    public class tinhthanhbus
    {
        public IRepository<tinhthanh> tinhthanhrespository;

        public tinhthanhbus()
        {
            tinhthanhrespository = new GenericRepository<tinhthanh>();
        }

        public List<tinhthanhdto> list()
        {
            return tinhthanhrespository.GetAll().Select(c => new tinhthanhdto(c)).ToList();
        }

        public bool update(tinhthanh _tt)
        {
            tinhthanh tt = tinhthanhrespository.First(c => c.id == _tt.id);
            tt.matt = _tt.matt;
            tt.tentt = _tt.tentt;
            return tinhthanhrespository.Update(tt);
        }
    }
}
