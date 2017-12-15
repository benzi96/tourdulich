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
using Core.dto;
using tourdulichweb.Models;

namespace tourdulichweb.Controllers
{
    public class thongkenhanvienController : Controller
    {
        nhanvienbus tkbus = new nhanvienbus();

        // GET: chitietthanhtoans
        public ActionResult Index(string idnhanvien, string tungay, string denngay)
        {
            int id;
            List<solanditour> sls = null;
            DateTime startdate, enddate;
            if (int.TryParse(idnhanvien, out id) && DateTime.TryParse(tungay, out startdate) && DateTime.TryParse(denngay, out enddate))
            {
                sls = tkbus.thongkesolanditour(id, startdate, enddate);
            }

            thongkenhanvienviewmodel tknvvm = new thongkenhanvienviewmodel();
            tknvvm.sldts = sls;
            ViewBag.idnhanvien = new SelectList(tkbus.listnv(), "id", "socmnd_tenkh");
            return View(tknvvm);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
