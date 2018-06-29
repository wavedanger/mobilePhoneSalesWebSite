using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Division
    {
        public Division()
        {
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public string Name { get; set; }
        public int? TheArea { get; set; }
        public string Receiver { get; set; }
        public string PhoneNum { get; set; }

        public Area TheAreaNavigation { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
