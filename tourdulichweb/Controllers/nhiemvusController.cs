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
    public class nhiemvusController : Controller
    {
        nhiemvubus nvbus = new nhiemvubus();

        // GET: nhiemvus
        public ActionResult Index()
        {
            return View(nvbus.db.GetAll().ToList());
        }

        // GET: nhiemvus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhiemvu nhiemvu = nvbus.db.First(c=>c.id == id);
            if (nhiemvu == null)
            {
                return HttpNotFound();
            }
            return View(nhiemvu);
        }

        // GET: nhiemvus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nhiemvus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,tennhiemvu")] nhiemvu nhiemvu)
        {
            if (ModelState.IsValid)
            {
                nvbus.db.Add(nhiemvu);
                return RedirectToAction("Index");
            }

            return View(nhiemvu);
        }

        // GET: nhiemvus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhiemvu nhiemvu = nvbus.db.First(c => c.id == id);
            if (nhiemvu == null)
            {
                return HttpNotFound();
            }
            return View(nhiemvu);
        }

        // POST: nhiemvus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,tennhiemvu")] nhiemvu nhiemvu)
        {
            if (ModelState.IsValid)
            {
                nvbus.db.Attach(nhiemvu);
                return RedirectToAction("Index");
            }
            return View(nhiemvu);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
