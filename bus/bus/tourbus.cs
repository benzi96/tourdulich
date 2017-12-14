using Core.dto;
using Core;
using System.Collections.Generic;
using System.Linq;

namespace Core.bus
{
    public class tourbus
    {
        public IRepository<tour> tourrespository;
        public IRepository<loaihinhdulich> loaihinhrespository;

        public tourbus()
        {
            tourrespository = new GenericRepository<tour>();
            loaihinhrespository = new GenericRepository<loaihinhdulich>();
        }

        public List<tourdto> list()
        {
            return tourrespository.GetAll().Select(c => new tourdto(c)).ToList();
        }
        public Dictionary<string, string> listlh()
        {
            Dictionary<string, string> lhs = new Dictionary<string, string>();
            var loaihinhs = loaihinhrespository.GetAll();
            foreach (loaihinhdulich lh in loaihinhs)
            {
                lhs.Add(lh.id.ToString(), lh.tenloaihinh);
            }
            return lhs;
        }

        public bool add(tour _t)
        {
            bool s = tourrespository.Add(_t);
            _t.loaihinhdulich = loaihinhrespository.First(c => c.id == _t.idlh);
            return s;
        }

        public bool update(tour _t)
        {
            tour t = tourrespository.First(c => c.id == _t.id);
            t.tentour = _t.tentour;
            t.dacdiem = _t.dacdiem;
            t.idlh = _t.idlh;
            return tourrespository.Update(t);
        }
    }
}
