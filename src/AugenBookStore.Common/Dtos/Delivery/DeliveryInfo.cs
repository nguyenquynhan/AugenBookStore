using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public abstract class DeliveryInfo
    {
        public string DeliveryService { get; set; }
        public double Cost { get; set; }
        public abstract string ToString();
    }
}
