using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Phone
    {
        public Phone()
        {
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public string Name { get; set; }
        public string Introduce { get; set; }
        public string Price { get; set; }
        public string Img { get; set; }
        public int PhoneId { get; set; }
        public string Price2 { get; set; }
        public string Brand { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
