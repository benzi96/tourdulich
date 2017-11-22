using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;
using bus.dto;

namespace bus.bus
{
    public class thongketourbus
    {
        IRepository<doandulich> db;
        IRepository<giatour> db1;
        IRepository<chitietdoandulich> db2;
        IRepository<tour> db3;
        thongkechiphibus tkcpbus;
        public thongketourbus()
        {
            db = new GenericRepository<doandulich>();
            db1 = new GenericRepository<giatour>();
            db2 = new GenericRepository<chitietdoandulich>();
            db3 = new GenericRepository<tour>();
            tkcpbus = new thongkechiphibus();
        }
        
        public decimal tongdoanhthu(int idtour)
        {
            decimal tong = 0;
            var doandulichs = db.Find(c => c.idtour == idtour);
            foreach(doandulich ct in doandulichs )
            {
                decimal gia = (decimal)db1.GetQuery().OrderByDescending(c => c.id).FirstOrDefault(c => c.tungay <= ct.ngaykhoihanh && c.denngay >= ct.ngaykhoihanh).gia;
                int soluongkhach = db2.Find(c => c.iddoandulich == ct.id).Count();
                tong = gia * soluongkhach;
            }
            return tong;
        }

        public List<chitietdoanhthu> thongkedoanhthu(int idtour)
        {
            var doandulichs = db.Find(c => c.idtour == idtour);
            List<chitietdoanhthu> cts = new List<chitietdoanhthu>();
            foreach (doandulich ct in doandulichs)
            {
                chitietdoanhthu ctdt = new chitietdoanhthu();
                ctdt.tendoan = ct.tendoan;
                ctdt.tentour = ct.tour.tentour;
                ctdt.gia = (decimal)db1.GetQuery().OrderByDescending(c => c.id).FirstOrDefault(c => c.tungay <= ct.ngaykhoihanh && c.denngay >= ct.ngaykhoihanh).gia;
                ctdt.soluongkhach = db2.Find(c => c.iddoandulich == ct.id).Count();
                ctdt.tong = ctdt.gia * ctdt.soluongkhach;
                ctdt.tongchiphi = tkcpbus.tongchiphi(ct.id);
                ctdt.doanhthu = ctdt.tong - ctdt.tongchiphi;
            }
            return cts;
        }

        public List<chitietdoanhthu> thongkedoanhthu(int idtour, DateTime tungay, DateTime denngay)
        {
            var doandulichs = db.Find(c => c.idtour == idtour && c.ngaykhoihanh >= tungay && c.ngaykhoihanh <= denngay);
            List<chitietdoanhthu> cts = new List<chitietdoanhthu>();
            foreach (doandulich ct in doandulichs)
            {
                chitietdoanhthu ctdt = new chitietdoanhthu();
                ctdt.tendoan = ct.tendoan;
                ctdt.tentour = ct.tour.tentour;
                ctdt.gia = (decimal)db1.GetQuery().OrderByDescending(c => c.id).FirstOrDefault(c => c.tungay <= ct.ngaykhoihanh && c.denngay >= ct.ngaykhoihanh).gia;
                ctdt.soluongkhach = db2.Find(c => c.iddoandulich == ct.id).Count();
                ctdt.tong = ctdt.gia * ctdt.soluongkhach;
                ctdt.tongchiphi = tkcpbus.tongchiphi(ct.id);
                ctdt.doanhthu = ctdt.tong - ctdt.tongchiphi;
            }
            return cts;
        }

        public List<tinhhinhhoatdongcuatour> tinhhinhhoatdong()
        {
            List<tinhhinhhoatdongcuatour> thhdct = new List<tinhhinhhoatdongcuatour>();
            var tours = db3.GetAll();
            foreach (tour t in tours)
            {
                tinhhinhhoatdongcuatour th = new tinhhinhhoatdongcuatour();
                th.tentour = t.tentour;
                var doandulichs = db.Find(c => c.idtour == t.id);
                th.soluongdoandulich = doandulichs.Count();
                th.tongchiphi = tkcpbus.tongchiphi(doandulichs);
                th.tong = tongdoanhthu(t.id);
                th.tongdoanhthu = th.tong - th.tongchiphi;
                thhdct.Add(th);
            }
            return thhdct;
        }
    }
}
