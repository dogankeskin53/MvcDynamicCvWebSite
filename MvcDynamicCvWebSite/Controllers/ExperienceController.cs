using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDynamicCvWebSite.Models.Entity;
using MvcDynamicCvWebSite.Repository; 

namespace MvcDynamicCvWebSite.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperianceRepository eRepo = new ExperianceRepository();
        public ActionResult Index()
        {
            var values = eRepo.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperiance()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperiance(Experience p)
        {
            //generic repositorye gider ve ekleme yapar
            eRepo.TAdd(p);
            //kendi sayfasına yönlendiriyor
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Gelen id ile Experience tablosunda ki id aranır
        /// bulununca siler
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteExperience(int id) {
            Experience t = eRepo.Find(x => x.ID == id);
            eRepo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult GetExperience(int id )
        {
            Experience t = eRepo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult GetExperience(Experience p)
        {
            Experience t = eRepo.Find(x => x.ID == p.ID);
            t.ID = p.ID;
            t.Heading = p.Heading;
            t.SubHeading = p.SubHeading;
            t.Date = p.Date;
            t.Description = p.Description;
            eRepo.TUpdate(t);
            return RedirectToAction("Index");
        }
        
    }
}