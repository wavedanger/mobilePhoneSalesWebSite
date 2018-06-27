using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mobilePhoneSalesWebSite.Models;

namespace mobilePhoneSalesWebSite.Controllers
{
    public class SchoolController : Controller
    {
        private DDATABASEDATADEMOMDFContext _dbContext;
        public SchoolController(DDATABASEDATADEMOMDFContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /<controller>/ 
        public IActionResult Index()
        {
            School s = new School();
            return View(s);
        }
        [HttpPost]
        public IActionResult Index(School s)
        {
            _dbContext.School.Add(s);
            _dbContext.SaveChanges();
            var schools = _dbContext.School.AsQueryable<School>(); ;
            return View("SchoolList", schools);
        }
    }
}