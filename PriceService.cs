using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class PriceService
    {
        public static Price PriceToUAH(double costInUSD)
        {
            var price = new Price();
            var exchanngeRates = 27.4;
            var costInUAH = costInUSD * exchanngeRates;
            price.Cost = Math.Round(costInUAH, 2);
            price.Currency = Currency.UAH;
            return price;
        }

        public static Price PriceInUSD(double costInUSD)
        {
            var price = new Price();
            price.Cost = Math.Round(costInUSD, 2);
            price.Currency = Currency.USD;
            return price;
        }
    }
}
