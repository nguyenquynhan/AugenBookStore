using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class MotorbikeDelivery : DeliveryType
    {
        private string _name;
        private double _baseCost;
        public MotorbikeDelivery()
        {
            _name = "Motorbike";
            _baseCost = 5;
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
