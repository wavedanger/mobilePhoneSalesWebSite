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
            ViewBag.phoneclass = new[] { "小米", "华为", "苹果", "三星" };
            //var phones = _dbContext.Phone.AsQueryable<Phone>();
            //return View(phones);
            HomeIndexViewModel ivm = new HomeIndexViewModel();
            ivm.Phones = new List<PhoneList>();
            ivm.SpeedBuy = new List<PhoneList>();
            ivm.SpeedBuy2 = new List<PhoneList>();
            ivm.Hot = new List<PhoneList>();
            ivm.Hot2 = new List<PhoneList>();
            ivm.Hot3 = new List<PhoneList>();
            ivm.Hot4 = new List<PhoneList>();
            var Phones= _dbContext.Phone.Where<Phone>(e => e.ObjId > 0).Take<Phone>(6);
            var SpeedBuy = _dbContext.Phone.Where<Phone>(e => e.ObjId > 6).Take<Phone>(4);
            var SpeedBuy2 = _dbContext.Phone.Where<Phone>(e => e.ObjId > 10).Take<Phone>(4);
            //var AllPhones = _dbContext.Phone.Where<Phone>(e => e.ObjId > 0).Take<Phone>(4);
            var Hot = _dbContext.Phone.Where<Phone>(e => e.Brand == "小米").Take<Phone>(4);
            var Hot2 = _dbContext.Phone.Where<Phone>(e => e.Brand == "华为").Take<Phone>(4);
            var Hot3 = _dbContext.Phone.Where<Phone>(e => e.Brand == "苹果").Take<Phone>(4);
            var Hot4 = _dbContext.Phone.Where<Phone>(e => e.Brand == "三星").Take<Phone>(4);
            foreach (var p in Phones)
            {
                PhoneList pl = new PhoneList();
                pl.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.Phones.Add(pl);
            }
            foreach (var p in SpeedBuy)
            {
                    PhoneList left = new PhoneList();
                    left.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                    ivm.SpeedBuy.Add(left);
            }
            foreach (var p in SpeedBuy2)
            {
                PhoneList right = new PhoneList();
                right.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.SpeedBuy2.Add(right);
            }
            foreach(var p in Hot)
            {
                PhoneList mi = new PhoneList();
                mi.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.Hot.Add(mi);
            }
            foreach (var p in Hot2)
            {
                PhoneList p1 = new PhoneList();
                p1.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.Hot2.Add(p1);
            }
            foreach (var p in Hot3)
            {
                PhoneList p1 = new PhoneList();
                p1.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.Hot3.Add(p1);
            }
            foreach (var p in Hot4)
            {
                PhoneList p1 = new PhoneList();
                p1.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.Hot4.Add(p1);
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
        public IActionResult Phonedetail(int? id)
        {
            ViewData["Message"] = "Your application Phonedetail page.";
            PhoneList pl = new PhoneList();
            pl.p = _dbContext.Phone.Single<Phone>(e => e.ObjId == id);
            return View(pl);
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
        public IActionResult AllPhone()
        {
            ViewData["Message"] = "Your application AllPhone page.";
            HomeIndexViewModel ivm = new HomeIndexViewModel();
            ivm.AllPhones = new List<PhoneList>();
            var AllPhones = _dbContext.Phone.Where<Phone>(e => e.ObjId > 0);
            foreach (var p in AllPhones)
            {
                PhoneList pl = new PhoneList();
                pl.p = new Phone { ObjId = p.ObjId, Name = p.Name, Introduce = p.Introduce, Img = p.Img, Price = p.Price, Price2 = p.Price2 };
                ivm.AllPhones.Add(pl);
            }
            return View(ivm);
        }
    }
}
