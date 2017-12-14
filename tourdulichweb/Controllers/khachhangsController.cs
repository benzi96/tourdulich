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

namespace tourdulichweb.Controllers
{
    public class khachhangsController : Controller
    {
        khachhangbus khbus = new khachhangbus();

        // GET: khachhangs
        public ActionResult Index()
        {
            var khachhang = khbus.db.GetAll("gioitinh1");
            return View(khachhang.ToList());
        }

        // GET: khachhangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khachhang khachhang = khbus.db.First(c => c.id == id);
            if (khachhang == null)
            {
                return HttpNotFound();
            }
            return View(khachhang);
        }

        // GET: khachhangs/Create
        public ActionResult Create()
        {
            ViewBag.gioitinh = new SelectList(khbus.db1.GetAll(), "id", "tengioitinh");
            return View();
        }

        // POST: khachhangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tenkhachhang,socmnd,diachi,gioitinh,sodienthoai")] khachhang khachhang)
        {
            if (ModelState.IsValid)
            {
                khbus.db.Add(khachhang);
                return RedirectToAction("Index");
            }

            ViewBag.gioitinh = new SelectList(khbus.db1.GetAll(), "id", "tengioitinh", khachhang.gioitinh);
            return View(khachhang);
        }

        // GET: khachhangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            khachhang khachhang = khbus.db.First(c => c.id == id);
            if (khachhang == null)
            {
                return HttpNotFound();
            }
            ViewBag.gioitinh = new SelectList(khbus.db1.GetAll(), "id", "tengioitinh", khachhang.gioitinh);
            return View(khachhang);
        }

        // POST: khachhangs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tenkhachhang,socmnd,diachi,gioitinh,sodienthoai")] khachhang khachhang)
        {
            if (ModelState.IsValid)
            {
                khbus.db.Attach(khachhang);
                return RedirectToAction("Index");
            }
            ViewBag.gioitinh = new SelectList(khbus.db1.GetAll(), "id", "tengioitinh", khachhang.gioitinh);
            return View(khachhang);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
