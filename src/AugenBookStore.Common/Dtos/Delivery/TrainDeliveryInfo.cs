using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Common.Dtos.Delivery
{
    public class TrainDeliveryInfo : DeliveryInfo
    {
        public TrainDeliveryInfo(string deliveryService, double cost)
        {
            DeliveryService = deliveryService;
            Cost = cost;
        }
        public int TrainNo { get; set; }
        public int StationOfArrival { get; set; }
        public DateTime DateOfArrival { get; set; }
        public override string ToString()
        {
            return $"Delivery Service: {DeliveryService}, Cost: ${Cost}, Train No: {TrainNo}, Station Of Arrival: {StationOfArrival}, Date Of Arrival: {DateOfArrival.ToString("dd/MM/yyyy")}";
        }
    }
}
