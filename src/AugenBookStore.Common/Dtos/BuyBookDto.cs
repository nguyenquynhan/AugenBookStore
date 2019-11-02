using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos
{
    public class BuyBookDto
    {
        public string DeliveryService { get; set; }
        public double DeliveryCost { get; set; }
        public string BookTitle { get; set; }
        public string BookId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
    }
}
