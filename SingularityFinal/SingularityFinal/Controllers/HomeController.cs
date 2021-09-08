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

        [HttpPost]
        public JsonResult UpdateData(List p)
        {
                var oldp = context.Lists.SingleOrDefault(e => e.id == p.id);
                oldp.name = p.name;
                oldp.price = p.price;
                context.SaveChanges();
                return Json(new { success = true }); 
        }
        [HttpPost]
        public JsonResult AddData(List u)
        {
            context.Lists.Add(u);
            context.SaveChanges();
            return Json(new { success = true });

        }
    }

}