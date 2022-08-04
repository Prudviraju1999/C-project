using Stocks;
using System;
using System.Collections;

namespace StockTrading
{
    class TickerDetails
    {
        public ArrayList arrTickers = new ArrayList();
        public void AddTickerDetails(string name, DateTime listedDate, int customerId)
        {
            Ticker tickerDetails = new Ticker()
            {
                Name = name,
                DateListed = listedDate,
                Id = customerId
            };
            arrTickers.Add(tickerDetails);
        }
    }
}
