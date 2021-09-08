using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SingularityFinal.Models;
using System.Collections;
using System.Dynamic;
using System.Web.Routing;

namespace SingularityFinal.Controllers
{
    public class HomeController : Controller
    {
        FinalTechnicalTestEntities context = new FinalTechnicalTestEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public JsonResult GetList()
        {
            return Json(context.Lists.ToList(), JsonRequestBehavior.AllowGet);
        }
    }

}