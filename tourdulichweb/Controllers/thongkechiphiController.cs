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
    public class thongkechiphiController : Controller
    {
        thongkechiphibus tkbus = new thongkechiphibus();
        doandulichbus ddlbus = new doandulichbus();
        phieuthanhtoanbus pttbus = new phieuthanhtoanbus();

        // GET: chitietthanhtoans
        public ActionResult Index(string iddoandulich, string idloaiphieu)
        {
            int j, iddl;
            List<chitietchiphi> cts = null;

            if (int.TryParse(idloaiphieu, out j) && int.TryParse(iddoandulich, out iddl))
            {
                if (j == 5) cts = tkbus.chiphi(iddl);
                else cts = tkbus.chiphi(iddl, j);
            }

            thongkechiphiviewmodel tkcpvm = new thongkechiphiviewmodel(cts, j);
            ViewBag.iddoandulich = new SelectList(ddlbus.db.GetAll(), "id", "tendoan");
            ViewBag.idloaiphieu = new SelectList(pttbus.listnew(), "id", "tenloaiphieu");
            return View(tkcpvm);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
