using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to GitHub demo! (edited online)";
            var provinces = new[] {
                new Province() 
                { 
                    Name = "Buenos Aires", 
                    Population = 15625084,
                    Area = 307571,
                    Capital = "La Plata",
                    Iso = "AR-B"
                }
            };
            return View(provinces.OrderBy(x => x.Name));
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
