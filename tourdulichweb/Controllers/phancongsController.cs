using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using entities;
using bus.bus;

namespace tourdulichweb.Controllers
{
    public class phancongsController : Controller
    {
        phancongbus pcbus = new phancongbus();

        // GET: phancongs
        public ActionResult Index()
        {
            var phancong = pcbus.db.GetAll("nhiemvu", "nhanvien", "doandulich");
            return View(phancong.ToList());
        }

        // GET: phancongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phancong phancong = pcbus.db.First(c=>c.id==id);
            if (phancong == null)
            {
                return HttpNotFound();
            }
            return View(phancong);
        }

        // GET: phancongs/Create
        public ActionResult Create()
        {
            ViewBag.iddoandulich = new SelectList(pcbus.db3.GetAll(), "id", "tendoan");
            ViewBag.idnhanvien = new SelectList(pcbus.db2.GetAll(), "id", "tennhanvien");
            ViewBag.idnhiemvu = new SelectList(pcbus.db1.GetAll(), "id", "tennhiemvu");
            return View();
        }

        // POST: phancongs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idnhanvien,idnhiemvu,iddoandulich")] phancong phancong)
        {
            if (ModelState.IsValid)
            {
                pcbus.db.Add(phancong);
                return RedirectToAction("Index");
            }

            ViewBag.iddoandulich = new SelectList(pcbus.db3.GetAll(), "id", "tendoan");
            ViewBag.idnhanvien = new SelectList(pcbus.db2.GetAll(), "id", "tennhanvien");
            ViewBag.idnhiemvu = new SelectList(pcbus.db1.GetAll(), "id", "tennhiemvu");
            return View(phancong);
        }

        // GET: phancongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            phancong phancong = pcbus.db.First(c=>c.id==id);
            if (phancong == null)
            {
                return HttpNotFound();
            }
            ViewBag.iddoandulich = new SelectList(pcbus.db3.GetAll(), "id", "tendoan");
            ViewBag.idnhanvien = new SelectList(pcbus.db2.GetAll(), "id", "tennhanvien");
            ViewBag.idnhiemvu = new SelectList(pcbus.db1.GetAll(), "id", "tennhiemvu");
            return View(phancong);
        }

        // POST: phancongs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idnhanvien,idnhiemvu,iddoandulich")] phancong phancong)
        {
            if (ModelState.IsValid)
            {
                pcbus.db.Update(phancong);
                return RedirectToAction("Index");
            }
            ViewBag.iddoandulich = new SelectList(pcbus.db3.GetAll(), "id", "tendoan");
            ViewBag.idnhanvien = new SelectList(pcbus.db2.GetAll(), "id", "tennhanvien");
            ViewBag.idnhiemvu = new SelectList(pcbus.db1.GetAll(), "id", "tennhiemvu");
            return View(phancong);
        }

        //// GET: phancongs/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    phancong phancong = db.phancong.Find(id);
        //    if (phancong == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phancong);
        //}

        //// POST: phancongs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    phancong phancong = db.phancong.Find(id);
        //    db.phancong.Remove(phancong);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            base.Dispose(disposing);
        }
    }
}
