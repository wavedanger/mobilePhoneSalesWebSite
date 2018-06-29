using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Area
    {
        public Area()
        {
            Division = new HashSet<Division>();
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public string Name { get; set; }
        public int? TheCity { get; set; }

        public City TheCityNavigation { get; set; }
        public ICollection<Division> Division { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
