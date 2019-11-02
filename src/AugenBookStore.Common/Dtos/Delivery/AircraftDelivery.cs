using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class AircraftDelivery : DeliveryType
    {
        private string _name;
        public AircraftDelivery()
        {
            _name = "Aircraft";
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
