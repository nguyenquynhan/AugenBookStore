using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services
{
    public interface IDeliveryInfoGeneratorService
    {
        string Generate(string deliveryService, double cost);
    }
}
