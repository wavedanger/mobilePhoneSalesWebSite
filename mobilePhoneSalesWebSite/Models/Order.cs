using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Order
    {
        public int ObjId { get; set; }
        public int? User { get; set; }
        public DateTime? OrderTime { get; set; }
        public int? ThePhone { get; set; }
        public double? Amt { get; set; }
        public int? ThePayment { get; set; }
        public int? TheProvince { get; set; }
        public int? TheCity { get; set; }
        public int? TheArea { get; set; }
        public int? TheDivision { get; set; }

        public Area TheAreaNavigation { get; set; }
        public City TheCityNavigation { get; set; }
        public Division TheDivisionNavigation { get; set; }
        public Payment ThePaymentNavigation { get; set; }
        public Phone ThePhoneNavigation { get; set; }
        public Province TheProvinceNavigation { get; set; }
    }
}
