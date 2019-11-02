using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services.Delivery
{
    public class CostContext
    {
        private ICostStrategy _costStrategy;
        public void SetStrategy(ICostStrategy costStrategy)
        {
            _costStrategy = costStrategy;
        }

        public double CalculateCost(int month)
        {
            return _costStrategy.CalculateCost(month);
        }
    }
}
