using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mobilePhoneSalesWebSite.Models;
using System.Net;
namespace mobilePhoneSalesWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DDATABASEDATADEMOMDFContext _dbContext;
        public HomeController(DDATABASEDATADEMOMDFContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.navs = new[]{"手机好店","热门","新品","周边","服务"};
            //var phones = _dbContext.Phone.AsQueryable<Phone>();
            //return View(phones);
            HomeIndexViewModel ivm = new HomeIndexViewModel();
            ivm.AllPhones = new List<PhoneList>();
            ivm.SpeedBuy = new List<PhoneList>();
            var AllPhones = _dbContext.Phone.Where<Phone>(e =>e.ObjId > 0);
            //var AllPhones = _dbContext.Phone.Where<Phone>(e => e.ObjId > 0).Take<Phone>(4);
            foreach (var p in AllPhones)
            {
                PhoneList pl = new PhoneList();
                pl.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.AllPhones.Add(pl);
            }
            return View(ivm);
            //return View();
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
