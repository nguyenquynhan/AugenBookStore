using AugenBookStore.Common.Dtos.Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services
{
    public class DeliveryInfoGeneratorService: IDeliveryInfoGeneratorService
    {
        private Random _random;
        public DeliveryInfoGeneratorService()
        {
            _random = new Random();
        }
        public string Generate(string deliveryService, double cost)
        {
            switch (deliveryService)
            {
                case "Aircraft":
                    var aircraft = new AircraftDeliveryInfo(deliveryService, cost);
                    aircraft.FlightNo = _random.Next(100, 1000);
                    aircraft.GateOfArrival = _random.Next(1, 10);
                    aircraft.DateOfArrival = new DateTime(2019, 11, _random.Next(1, 30));
                    return aircraft.ToString();
                case "Train":
                    var train = new TrainDeliveryInfo(deliveryService, cost);
                    train.TrainNo = _random.Next(100, 1000);
                    train.StationOfArrival = _random.Next(1, 10);
                    train.DateOfArrival = new DateTime(2019, 11, _random.Next(1, 30));
                    return train.ToString();
                default:
                    var motorbike = new MotorbikeDeliveryInfo(deliveryService, cost);
                    motorbike.DriverName = "Nhan Nguyen";
                    motorbike.Mobile = "0909090909";
                    motorbike.DeliveryDate = new DateTime(2019, 11, _random.Next(1, 30));
                    return motorbike.ToString();
            }
        }
    }
}
