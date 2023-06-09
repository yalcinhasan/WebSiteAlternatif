using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteAlternatif.Models.Entity;

namespace WebSiteAlternatif.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        WebSiteDBEntities db = new WebSiteDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHAKKIMDA.ToList();
            return View(degerler);
        }

        public ActionResult AddMessage() { return View(); }

        [HttpPost]
        public ActionResult AddMessage(TBLILETISIM tBLILETISIM)
        {
            db.TBLILETISIM.Add(tBLILETISIM);
            db.SaveChanges();//burası olmadan veri tabanına kaydetmez
            return RedirectToAction("AddMessage");
        }
    }
}