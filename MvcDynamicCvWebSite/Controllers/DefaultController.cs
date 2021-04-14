using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//model çağırma
using MvcDynamicCvWebSite.Models.Entity;

namespace MvcDynamicCvWebSite.Controllers
{
    public class DefaultController : Controller
    {
        // DB Nesnesi içerisindeki sınıflara erişim sağlanabilir.
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.About.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            return PartialView();
        }


    }
}