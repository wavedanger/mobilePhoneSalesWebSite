using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mobilePhoneSalesWebSite.Models
{
    public class HomeIndexViewModel
    {

        public List<PhoneList> AllPhones { get; set; }
        public List<PhoneList> SpeedBuy { get; set; }
    }
    public class PhoneList
    {
        public Phone p { get; set; }
    }
}
