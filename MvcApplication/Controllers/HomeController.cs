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
        public readonly ProvincesRepository ProvincesRepository = new ProvincesRepository();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to GitHub demo! (edited online)";
            var provinces = ProvincesRepository.GetAll();
            return View(provinces);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
