using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}