using AugenBookStore.Common.Dtos.Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services
{
    public interface IDeliveryService
    {
        List<DeliveryType> GetAllDeliveryTypes(int month);
    }
}
