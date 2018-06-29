using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payment = new HashSet<Payment>();
        }

        public int ObjId { get; set; }
        public string TypeName { get; set; }
        public string Url { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
