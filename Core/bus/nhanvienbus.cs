using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.dto;

namespace Core.bus
{
    public class nhanvienbus
    {
        public IRepository<nhanvien> db;
        public IRepository<gioitinh> db1;
        public IRepository<phancong> db2;
        public IRepository<tour> db3;
        public nhanvienbus()
        {
            db = new GenericRepository<nhanvien>();
            db1 = new GenericRepository<gioitinh>();
            db2 = new GenericRepository<phancong>();
            db3 = new GenericRepository<tour>();
        }
        public List<nguoidto> listnv()
        {
            return db.GetAll().Select(c => new nguoidto(c)).ToList();
        }
        public List<solanditour> thongkesolanditour(int id, DateTime tungay, DateTime denngay)
        {
            List<solanditour> sldts = new List<solanditour>();
            string tennv = db.Find(c => c.id == id).FirstOrDefault().tennhanvien;
            foreach(tour t in db3.GetAll())
            {
                solanditour sl = new solanditour();
                sl.tennv = tennv;
                sl.tentour = t.tentour;
                sl.solan = db2.Find(c => c.doandulich.tour.id == t.id 
                                        && c.idnhanvien == id 
                                        && c.doandulich.ngaykhoihanh >= tungay 
                                        && c.doandulich.ngaykhoihanh <= denngay)
                                        .Select(c=>c.iddoandulich)
                                        .Distinct().Count();
                sldts.Add(sl);
            }
            return sldts;
        }
    }
}
