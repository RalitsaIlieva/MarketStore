using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
   public class GoldCard:Card
    {
        public override decimal GetDiscountRate()
        {
            if (Turnover < 100)
            {
                return DiscountRate = 0.02m;
            }
            else
            {
                DiscountRate = 0.02m;
               
                    for (int i = 0; i < Turnover; i++)
                    {
                        DiscountRate += 0.01m;
                        i += 100;
                    }
                if (DiscountRate >= 0.1m)
                {
                    return 0.1m;
                }
                else
                {
                    return DiscountRate;
                }
            }
        }
    }
}
