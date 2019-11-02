using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class MotorbikeDeliveryInfo : DeliveryInfo
    {
        public MotorbikeDeliveryInfo(string deliveryService, double cost)
        {
            DeliveryService = deliveryService;
            Cost = cost;
        }
        public string DriverName { get; set; }
        public string Mobile { get; set; }
        public DateTime DeliveryDate { get; set; }
        public override string ToString()
        {
            return $"Delivery Service: {DeliveryService}, Cost: ${Cost}, Driver Name: {DriverName}, Mobile: {Mobile}, Delivery Date: {DeliveryDate.ToString("dd/MM/yyyy")}";
        }
    }
}
