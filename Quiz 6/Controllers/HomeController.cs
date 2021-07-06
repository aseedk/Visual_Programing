using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz_6.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Add(int? y, int? x)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = x + y;
            return View();
        }
        public ActionResult Sub(int? x, int? y)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = x - y;
            return View();
        }
        public ActionResult Mul(int? x, int? y)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = x * y;
            return View();
        }
        public ActionResult Div(int? x, int? y)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = x / y;
            return View();
        }
        public ActionResult Pow(double x, double y)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = Math.Pow(x,y);
            return View();
        }
        public ActionResult Mod(int? x, int? y)
        {
            ViewBag.Message = "Addition";
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.result = x % y;
            return View();
        }
    }
}