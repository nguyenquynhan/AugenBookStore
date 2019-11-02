using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public abstract class DeliveryType
    {
        public abstract string Name { get; }
        public double Cost { get; set; }
    }
}
