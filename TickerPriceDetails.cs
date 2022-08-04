using Stocks;
using System;
using System.Collections;

namespace StockTrading
{
    class TickerPriceDetails
    {
        public ArrayList arrTickerPrice = new ArrayList();
        public void AddTickerPriceDetails(int tickerPriceOne, DateTime tickerTime, int tickerId, int customerId)
        {
            TickerPrice tickerPrice = new TickerPrice()
            {
                Price = tickerPriceOne,
                TickerDateTime = tickerTime,
                TickerId = tickerId,
                Id = customerId
            };
            arrTickerPrice.Add(tickerPrice);
        }
    }
}
