using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services.Delivery
{
    public interface ICostStrategy
    {
        double CalculateCost(int month);
    }
}
