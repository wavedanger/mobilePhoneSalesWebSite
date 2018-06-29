using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public string Name { get; set; }

        public ICollection<City> City { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
