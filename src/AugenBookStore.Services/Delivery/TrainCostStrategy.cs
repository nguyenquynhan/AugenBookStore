using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services.Delivery
{
    public class TrainCostStrategy : ICostStrategy
    {
        public double CalculateCost(int month)
        {            
            return _baseCost * Factor(month);
        }

        private const double _baseCost = 10;
        private double Factor(int month)
        {
            if (month >= 6 && month <= 8)
            {
                return 0.8;
            }
            else if (month == 9)
            {
                return 1.8;
            }
            else
            {
                return 1;
            }
        }
    }
}
