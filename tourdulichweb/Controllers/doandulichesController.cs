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
using tourdulichweb.Models;

namespace tourdulichweb.Controllers
{
    public class doandulichesController : Controller
    {
        doandulichbus ddlbus = new doandulichbus();

        // GET: doanduliches
        public ActionResult Index()
        {
            var doandulich = ddlbus.db.GetAll("tour");
            return View(doandulich.ToList());
        }

        // GET: doanduliches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doandulich doandulich = ddlbus.db.First(c => c.id == id);
            if (doandulich == null)
            {
                return HttpNotFound();
            }
            return View(doandulich);
        }

        // GET: doanduliches/Create
        public ActionResult Create()
        {
            ViewBag.idtour = new SelectList(ddlbus.db1.GetAll(), "id", "tentour");
            ViewBag.idkhachhang = new SelectList(ddlbus.listkh(), "id", "socmnd_tenkh");
            return View();
        }

        // POST: doanduliches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idtour,ngaykhoihanh,ngayketthuc,chuongtrinhthamquan,tendoan")] doandulich doandulich,
                                   [Bind(Prefix ="ct")] chitietdoandulich[] ct)
        {
            if (ModelState.IsValid)
            {
                doandulich.chitietdoandulich = ct;
                ddlbus.add(doandulich);
                return RedirectToAction("Index");
            }
            ViewBag.idkhachhang = new SelectList(ddlbus.listkh(), "id", "socmnd_tenkh");
            ViewBag.idtour = new SelectList(ddlbus.db1.GetAll(), "id", "tentour", doandulich.idtour);
            doandulichviewmodel ddlvm = new doandulichviewmodel();
            doandulich.chitietdoandulich = ct;
            ddlvm.doandulich = doandulich;
            return View(ddlvm);
        }

        // GET: doanduliches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doandulich doandulich = ddlbus.db.First(c => c.id == id);
            if (doandulich == null)
            {
                return HttpNotFound();
            }
            ViewBag.idkhachhang = new SelectList(ddlbus.listkh(), "id", "socmnd_tenkh");
            ViewBag.idtour = new SelectList(ddlbus.db1.GetAll(), "id", "tentour", doandulich.idtour);
            return View(doandulich);
        }

        // POST: doanduliches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idtour,ngaykhoihanh,ngayketthuc,chuongtrinhthamquan,tendoan")] doandulich doandulich,
                                 [Bind(Prefix = "ct")] chitietdoandulich[] ct)
        {
            if (ModelState.IsValid)
            {
                ddlbus.update(doandulich, ct);
                return RedirectToAction("Index");
            }
            ViewBag.idkhachhang = new SelectList(ddlbus.listkh(), "id", "socmnd_tenkh");
            ViewBag.idtour = new SelectList(ddlbus.db1.GetAll(), "id", "tentour", doandulich.idtour);
            doandulichviewmodel ddlvm = new doandulichviewmodel();
            doandulich.chitietdoandulich = ct;
            ddlvm.doandulich = doandulich;
            return View(ddlvm);
        }

        //// GET: doanduliches/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    doandulich doandulich = db.doandulich.Find(id);
        //    if (doandulich == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(doandulich);
        //}

        //// POST: doanduliches/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    doandulich doandulich = db.doandulich.Find(id);
        //    db.doandulich.Remove(doandulich);
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
