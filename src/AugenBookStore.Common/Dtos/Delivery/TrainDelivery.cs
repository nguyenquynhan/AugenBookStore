using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class TrainDelivery : DeliveryType
    {
        private string _name;
        public TrainDelivery()
        {
            _name = "Train";
        }
        public override string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
