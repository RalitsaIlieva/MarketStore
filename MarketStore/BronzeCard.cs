using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class BronzeCard : Card
    {
        public override decimal GetDiscountRate()
        {
            if (Turnover < 100)
            {
                return DiscountRate = 0.00m;
            }
            else if (Turnover >= 100 && Turnover <= 300)
            {
                return DiscountRate = 0.01m;
            }
            else
            {
                return DiscountRate = 0.025m;
            }
        }
    }
}