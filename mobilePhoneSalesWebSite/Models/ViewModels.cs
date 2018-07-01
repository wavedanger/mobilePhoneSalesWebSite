﻿using System;
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
        public List<PhoneList> SpeedBuy2 { get; set; }
        public List<PhoneList> Hot { get; set; }
        public List<PhoneList> Hot2 { get; set; }
        public List<PhoneList> Hot3 { get; set; }
        public List<PhoneList> Hot4 { get; set; }
        public List<PhoneList> Phones { get; set; }
    }
    public class PhoneList
    {
        public Phone p { get; set; }
    }
    public class CartItem
    {
        public string productName { get; set; }
        public string feature { get; set; }
        public string price { get; set; }
        public string realPrice { get; set; }
        public int qty { get; set; }
        public string smallImg { get; set; }
    }
}
