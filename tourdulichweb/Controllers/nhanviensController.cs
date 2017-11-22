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
    public class nhanviensController : Controller
    {
        nhanvienbus nvbus = new nhanvienbus();

        // GET: nhanviens
        public ActionResult Index()
        {
            var nhanvien = nvbus.db.GetAll("gioitinh1");
            return View(nhanvien.ToList());
        }

        // GET: nhanviens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhanvien nhanvien = nvbus.db.First(c => c.id == id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            return View(nhanvien);
        }

        // GET: nhanviens/Create
        public ActionResult Create()
        {
            ViewBag.gioitinh = new SelectList(nvbus.db1.GetAll(), "id", "tengioitinh");
            return View();
        }

        // POST: nhanviens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tennhanvien,socmnd,diachi,gioitinh,sodienthoai")] nhanvien nhanvien)
        {
            if (ModelState.IsValid)
            {
                nvbus.db.Add(nhanvien);
                return RedirectToAction("Index");
            }

            ViewBag.gioitinh = new SelectList(nvbus.db1.GetAll(), "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        // GET: nhanviens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhanvien nhanvien = nvbus.db.First(c=>c.id==id);
            if (nhanvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.gioitinh = new SelectList(nvbus.db1.GetAll(), "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        // POST: nhanviens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tennhanvien,socmnd,diachi,gioitinh,sodienthoai")] nhanvien nhanvien)
        {
            if (ModelState.IsValid)
            {
                nvbus.db.Attach(nhanvien);
                return RedirectToAction("Index");
            }
            ViewBag.gioitinh = new SelectList(nvbus.db1.GetAll(), "id", "tengioitinh", nhanvien.gioitinh);
            return View(nhanvien);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
