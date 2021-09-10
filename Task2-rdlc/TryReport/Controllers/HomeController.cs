using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using System.IO;
using TryReport.Models;

namespace TryReport.Controllers
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
        public ActionResult StdReport()
        {
           LocalReport lr = new LocalReport();
           string p = Path.Combine(Server.MapPath("~/"), "Report1.rdlc");
           lr.ReportPath = p;
           List <Stock> l = new List<Stock>();
            l = context.Stocks.ToList();
            ReportDataSource rd = new ReportDataSource("DataSet1", l);
            lr.DataSources.Add(rd);
            string mt, enc, f;
            string[] s;
            Warning[] w;
            byte[] b = lr.Render("Pdf",null, out mt, out enc, out f, out s, out w);
            return File(b, mt);
            
        }
    }
}