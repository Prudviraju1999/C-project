using Stocks;
using System.Collections;

namespace StockTrading
{
    public class CustumerDetails
    {
        public  ArrayList arrCustomers = new ArrayList();
        public void AddCustomer(string name, int accountNumber, double fundBalance)
        {
            Customer customer = new Customer
            {
                Name = name,
                AccountNumber = accountNumber,
                FundBalance = fundBalance
            };
            arrCustomers.Add(customer);     
        }            

        public void UpdateCustomer()
        {
            
        }
        
    }
}
