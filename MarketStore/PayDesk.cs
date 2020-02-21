using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class PayDesk
    {
        public static decimal PurchaseValue { get; set; }

        public static void Output()
        {
            string typeOfCard = Console.ReadLine();

            Card card = null;
            switch (typeOfCard.ToLower())
            {
                case "bronze":
                    card = new BronzeCard();
                    break;

                case "silver":
                    card = new SilverCard();
                    break;

                case "gold":
                    card = new GoldCard();
                    break;

                default:
                    break;
            }
            if (card != null)
            {
                card.Turnover = Decimal.Parse(Console.ReadLine());
                PurchaseValue = Decimal.Parse(Console.ReadLine());
                decimal discountOfCurrentPurchase = PurchaseValue * card.GetDiscountRate();
                decimal total = PurchaseValue - discountOfCurrentPurchase;

                Console.WriteLine($"Purchase value: ${String.Format("{0:0.00}", PurchaseValue)}\n" +
                    $"Discount rate: {String.Format("{0:0.0}", card.GetDiscountRate() * 100)}%\n" +
                    $"Discount: ${String.Format("{0:0.00}", discountOfCurrentPurchase)}\n" +
                    $"Total: ${String.Format("{0:0.00}", total)}");
            }
        }
    }
}
