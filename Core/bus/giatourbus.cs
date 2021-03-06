﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.dto;

namespace Core.bus
{
    public class giatourbus
    {
        public IRepository<giatour> giatourrespository;
        public IRepository<tour> tourrespository;

        public giatourbus()
        {
            giatourrespository = new GenericRepository<giatour>();
            tourrespository = new GenericRepository<tour>();
        }

        public List<giatourdto> list()
        {
            return giatourrespository.GetAll().Select(c => new giatourdto(c)).ToList();
        }

	    public List<giatourdto> listgiatourhientai()
        {
	        DateTime a= DateTime.Now;
            List<giatourdto> gts = new List<giatourdto>();
            foreach (tour t in tourrespository.GetAll())
            {
                giatourdto gt = new giatourdto();
                if (giatourrespository.GetQuery().Any(c => c.tungay < a && c.denngay > a && c.idtour == t.id))
                {
                    gt = new giatourdto(giatourrespository.Find(c => c.tungay < a && c.denngay > a && c.idtour == t.id)
                                                                     .OrderByDescending(c => c.id)
                                                                     .FirstOrDefault());
                }
                else
                {
                    gt.ID = 0;
                    gt.tent = t.tentour;
                    gt.gia = 0;
                    gt.tungay = a;
                    gt.denngay = a;
                }
                gts.Add(gt);
            }
            return gts;
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

        public bool add(giatour _gt)
        {
            bool s = giatourrespository.Add(_gt);
            //load du lieu reference chua co
            _gt.tour = tourrespository.First(c => c.id == _gt.idtour);
            return s;
        }
        public bool update(giatour _gt)
        {
            giatour gt = giatourrespository.First(c => c.id == _gt.id);
            gt.idtour = _gt.idtour;
            gt.gia = _gt.gia;
            gt.tungay = _gt.tungay;
            gt.denngay = _gt.denngay;
            return giatourrespository.Update(gt);
        }
    }
}
