using AugenBookStore.Common.Dtos.Delivery;
using AugenBookStore.Services.Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services
{
    public class DeliveryService: IDeliveryService
    {
        public List<DeliveryType> GetAllDeliveryTypes(int month)
        {
            CostContext costContext = new CostContext();
            List<DeliveryType> deliveryTypes = new List<DeliveryType>();

            var mobike = new MotorbikeDelivery();
            costContext.SetStrategy(new MotorbikeCostStrategy());
            mobike.Cost = costContext.CalculateCost(month);
            deliveryTypes.Add(mobike);

            var train = new TrainDelivery();
            costContext.SetStrategy(new TrainCostStrategy());
            train.Cost = costContext.CalculateCost(month);
            deliveryTypes.Add(train);

            var aircraft = new AircraftDelivery();
            costContext.SetStrategy(new AircraftCostStrategy());
            aircraft.Cost = costContext.CalculateCost(month);
            deliveryTypes.Add(aircraft);

            return deliveryTypes;
        }
    }
}
