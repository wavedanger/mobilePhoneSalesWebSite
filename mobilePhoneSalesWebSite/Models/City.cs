using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class City
    {
        public City()
        {
            Area = new HashSet<Area>();
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public string Name { get; set; }
        public int? TheProvince { get; set; }

        public Province TheProvinceNavigation { get; set; }
        public ICollection<Area> Area { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
