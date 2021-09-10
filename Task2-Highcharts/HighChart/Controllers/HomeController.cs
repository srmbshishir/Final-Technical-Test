using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HighChart.Models;

namespace HighChart.Controllers
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
        public JsonResult GetData()
        {
            return Json(context.Stocks.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}