using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public abstract class Card
    {
        public string Owner { get; set; }
        public decimal Turnover { get; set; } 
        public  decimal DiscountRate { get; set; } 
        public abstract decimal GetDiscountRate(); 
    }

}