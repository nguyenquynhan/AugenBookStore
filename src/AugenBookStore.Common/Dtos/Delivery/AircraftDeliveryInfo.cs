using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class AircraftDeliveryInfo : DeliveryInfo
    {
        public AircraftDeliveryInfo(string deliveryService, double cost)
        {
            DeliveryService = deliveryService;
            Cost = cost;
        }
        public int FlightNo { get; set; }
        public int GateOfArrival { get; set; }
        public DateTime DateOfArrival { get; set; }
        public override string ToString()
        {
            return $"Delivery Service: {DeliveryService}, Cost: ${Cost}, Flight No: {FlightNo}, Gate Of Arrival: {GateOfArrival}, Date Of Arrival: {DateOfArrival.ToString("dd/MM/yyyy")}";
        }
    }
}
