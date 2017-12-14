using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.dto;

namespace Core.bus
{
    public class chitietdiemthamquanbus
    {
        public IRepository<chitietdiemthamquan> chitietdiemthamquanrespository;
        public IRepository<diadiem> diadiemrespository;
        public IRepository<tour> tourrespository;

        public chitietdiemthamquanbus()
        {
            chitietdiemthamquanrespository = new GenericRepository<chitietdiemthamquan>();
            diadiemrespository = new GenericRepository<diadiem>();
            tourrespository = new GenericRepository<tour>();
        }

        public List<chitietdiemthamquandto> list()
        {
            return chitietdiemthamquanrespository.GetAll().Select(c => new chitietdiemthamquandto(c)).ToList();
        }
        public Dictionary<string, string> listdd()
        {
            Dictionary<string, string> dds = new Dictionary<string, string>();
            var diadiems = diadiemrespository.GetAll();
            foreach (diadiem dd in diadiems)
            {
                dds.Add(dd.id.ToString(), dd.tendiadiem);
            }
            return dds;
        }

        public Dictionary<string, string> listt()
        {
            Dictionary<string, string> ts = new Dictionary<string, string>();
            var tours = tourrespository.GetAll();
            foreach (tour t in tours)
            {
                ts.Add(t.id.ToString(), t.tentour);
            }
            return ts;
        }

        public bool add(chitietdiemthamquan _ct)
        {
            bool s = chitietdiemthamquanrespository.Add(_ct);
            //load du lieu reference chua co
            _ct.tour = tourrespository.First(c => c.id == _ct.idtour);
            _ct.diadiem = diadiemrespository.First(c => c.id == _ct.iddiadiem);
            return s;
        }
        //public bool update(giatour _gt)
        //{
        //    giatour gt = giatourrespository.First(c => c.id == _gt.id);
        //    gt.idtour = _gt.idtour;
        //    gt.gia = _gt.gia;
        //    gt.tungay = _gt.tungay;
        //    gt.denngay = _gt.denngay;
        //    return giatourrespository.Update(gt);
        //}
    }
}
