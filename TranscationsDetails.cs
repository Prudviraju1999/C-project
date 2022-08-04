using Stocks;
using System.Collections;

namespace StockTrading
{
    class TranscationsDetails
    {
        public ArrayList arrTransaction = new ArrayList();
        public void AddTransactionDetails(bool isBuy, int tickerId, double cost, int quantity)
        {
            Transactions transactionDetails = new Transactions()
            {
                Type = isBuy,
                TickerId = tickerId,
                Cost = cost,
                Quantity = quantity
            };
            arrTransaction.Add(transactionDetails);
        }
    }
}
