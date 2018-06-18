using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mobilePhoneSalesWebSite.Models;

namespace mobilePhoneSalesWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your application Login page.";

            return View();
        }
        public IActionResult Register()
        {
            ViewData["Message"] = "Your application Register page.";

            return View();
        }
        public IActionResult Phonedetail()
        {
            ViewData["Message"] = "Your application Phonedetail page.";

            return View();
        }
        public IActionResult List()
        {
            ViewData["Message"] = "Your application List page.";

            return View();
        }
        public IActionResult Article()
        {
            ViewData["Message"] = "Your application Article page.";

            return View();
        }
    }
}
