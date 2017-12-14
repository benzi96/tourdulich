using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core;
using Core.bus;
using tourdulichweb.Models;

namespace tourdulichweb.Controllers
{
    public class phieuthanhtoansController : Controller
    {
        phieuthanhtoanbus pttbus = new phieuthanhtoanbus();

        // GET: phieuthanhtoans
        public ActionResult Index()
        {
            var phieuthanhtoan = pttbus.db.GetAll("doandulich", "loaiphieu");
            return View(phieuthanhtoan.ToList());
        }

        // GET: phieuthanhtoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuthanhtoan phieuthanhtoan = pttbus.db.First(c=>c.id==id);
            if (phieuthanhtoan == null)
            {
                return HttpNotFound();
            }
            return View(phieuthanhtoan);
        }

        // GET: phieuthanhtoans/Create
        public ActionResult Create()
        {
            ViewBag.iddoandulich = new SelectList(pttbus.db1.GetAll(), "id", "tendoan");
            ViewBag.idloaiphieu = new SelectList(pttbus.db2.GetAll(), "id", "tenloaiphieu");
            return View();
        }

        // POST: phieuthanhtoans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tenphieu,idloaiphieu,iddoandulich,ngaytao")] phieuthanhtoan phieuthanhtoan,
                                   [Bind(Prefix= "ct")] chitietthanhtoan[] chitietthanhtoan)
        {
            if (ModelState.IsValid)
            {
                phieuthanhtoan.chitietthanhtoan = chitietthanhtoan;
                pttbus.add(phieuthanhtoan);               
                return RedirectToAction("Index");
            }

            ViewBag.iddoandulich = new SelectList(pttbus.db1.GetAll(), "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(pttbus.db2.GetAll(), "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            phieuthanhtoanviewmodel pttvm = new phieuthanhtoanviewmodel();
            phieuthanhtoan.chitietthanhtoan = chitietthanhtoan;
            pttvm.phieuthanhtoan = phieuthanhtoan;
            return View(pttvm);
        }

        // GET: phieuthanhtoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phieuthanhtoan phieuthanhtoan = pttbus.db.First(c=>c.id==id);
            if (phieuthanhtoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.iddoandulich = new SelectList(pttbus.db1.GetAll(), "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(pttbus.db2.GetAll(), "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            return View(phieuthanhtoan);
        }

        // POST: phieuthanhtoans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tenphieu,idloaiphieu,iddoandulich,ngaytao")] phieuthanhtoan phieuthanhtoan)
        {
            if (ModelState.IsValid)
            {
                pttbus.update(phieuthanhtoan);
                return RedirectToAction("Index");
            }
            ViewBag.iddoandulich = new SelectList(pttbus.db1.GetAll(), "id", "tendoan", phieuthanhtoan.iddoandulich);
            ViewBag.idloaiphieu = new SelectList(pttbus.db2.GetAll(), "id", "tenloaiphieu", phieuthanhtoan.idloaiphieu);
            return View(phieuthanhtoan);
        }

        //// GET: phieuthanhtoans/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phieuthanhtoan phieuthanhtoan = db.phieuthanhtoan.Find(id);
        //    if (phieuthanhtoan == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phieuthanhtoan);
        //}

        //// POST: phieuthanhtoans/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    phieuthanhtoan phieuthanhtoan = db.phieuthanhtoan.Find(id);
        //    db.phieuthanhtoan.Remove(phieuthanhtoan);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
