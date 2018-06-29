using System;
using System.Collections.Generic;

namespace mobilePhoneSalesWebSite.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Order = new HashSet<Order>();
        }

        public int ObjId { get; set; }
        public double? Amount { get; set; }
        public int? ThePaymentType { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public DateTime? TransTime { get; set; }
        public string TransNo { get; set; }
        public int? PaymentState { get; set; }

        public PaymentType ThePaymentTypeNavigation { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
