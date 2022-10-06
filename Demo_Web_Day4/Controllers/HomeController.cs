using Demo_Web_Day4.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Web_Day4.Controllers
{
    public class HomeController : Controller
    {
        SchoolContext ctx = new SchoolContext();
        public ActionResult Index()
        {

            return View(ctx.Students.ToList());
        }

        public ActionResult StudentInfo()
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
    }
}