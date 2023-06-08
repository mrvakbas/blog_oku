using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using devamını_oku.Models;

namespace devamını_oku.Controllers
{
    public class HomeController : Controller
    {
        BlogsEntities db = new BlogsEntities();
        public ActionResult Test()
        {
            var deger = db.Blogs.ToList();
            return View(deger);
        }

        public ActionResult Details(int id)
        {
            var degerler = db.Blogs.Where(x => x.BlogID == id).ToList();
            return View(degerler);
        }

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
    }
}