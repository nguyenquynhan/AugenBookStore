using System;
using System.Collections.Generic;
using System.Text;

namespace AugenBookStore.Services.Delivery
{
    public class MotorbikeCostStrategy : ICostStrategy
    {
        public double CalculateCost(int month)
        {            
            return _baseCost * Factor(month);
        }

        private const double _baseCost = 5;
        private double Factor(int month)
        {
            if (month >= 6 && month <= 8)
            {
                return 0.5;
            }
            else if (month == 9)
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
        }
    }
}
