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

        public PartialViewResult Experience()
        {
            var experience = db.Experience.ToList();
            return PartialView(experience);
        }

        public PartialViewResult Education()
        {
            var education = db.Education.ToList();
            return PartialView(education);
        }

        public PartialViewResult MySkills()
        {
            var mySkills = db.MySkils.ToList();
            return PartialView(mySkills);
        }

        public PartialViewResult Interests()
        {
            var interests = db.Interests.ToList();
            return PartialView(interests);
        }

        public PartialViewResult Awards()
        {
            var awards = db.Awards.ToList();
            return PartialView(awards);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

        /// <summary>
        /// Butona tıklayınca post metodu çağrılacak
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        [HttpPost]
        public PartialViewResult Contact(Contact t)
        {
            ///Hangi bilgi gelirse gelsin t türünde alıp kayıt altına alıyoruz
            ///SaveChanges metodu ile kayıt ediyoruz.
            db.Contact.Add(t);
            db.SaveChanges();
            return PartialView();
        }


    }
}