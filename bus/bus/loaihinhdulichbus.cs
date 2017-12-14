using Core.dto;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.bus
{
    public class loaihinhdulichbus
    {
        public IRepository<loaihinhdulich> loaihinhdulichrespository;

        public loaihinhdulichbus()
        {
            loaihinhdulichrespository = new GenericRepository<loaihinhdulich>();
        }

        public List<loaihinhdulichdto> list()
        {
            return loaihinhdulichrespository.GetAll().Select(c => new loaihinhdulichdto(c)).ToList();
        }

        public bool update(loaihinhdulich _lh)
        {
            loaihinhdulich lh = loaihinhdulichrespository.First(c => c.id == _lh.id);
            lh.tenloaihinh = _lh.tenloaihinh;
            return loaihinhdulichrespository.Update(lh);
        }

    }
}
