using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bus.dto;
using entities;

namespace bus.bus
{
    public class diadiembus
    {
        public IRepository<diadiem> diadiemrespository;
        public IRepository<tinhthanh> tinhthanhrespository;

        public diadiembus()
        {
            diadiemrespository = new GenericRepository<diadiem>();
            tinhthanhrespository = new GenericRepository<tinhthanh>();
        }

        public List<diadiemdto> list()
        {
            return diadiemrespository.GetAll().Select(c => new diadiemdto(c)).ToList();
        }
        public Dictionary<string, string> listtt()
        {
            Dictionary<string, string> tts = new Dictionary<string, string>();
            var tinhthanhs = tinhthanhrespository.GetAll();
            foreach(tinhthanh tt in tinhthanhs)
            {
                tts.Add(tt.id.ToString(), tt.tentt);
            }
            return tts;
        }

        public bool add(diadiem _dd)
        {
            bool s = diadiemrespository.Add(_dd);
            //load du lieu reference chua co
            _dd.tinhthanh = tinhthanhrespository.First(c => c.id == _dd.idtt);
            return s;
        }
        public bool update(diadiem _dd)
        {
            diadiem dd = diadiemrespository.First(c => c.id == _dd.id);
            dd.tendiadiem = _dd.tendiadiem;
            dd.idtt = _dd.idtt;
            return diadiemrespository.Update(dd);
        }
    }
}
