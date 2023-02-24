using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Stock
    {
        string stockname;
        int shares;
        int shareprice;

        public Stock(string stockname, int shares, int shareprice)
        {
            this.stockname = stockname;
            this.shares = shares;
            this.shareprice = shareprice;
        }


        public int stockvalue()
        {
            int val = shares*shareprice;
            Console.WriteLine("The stock price is: " + val);
            return val;
        }
    }

    /*class StockPortfolio
    {
        List<Stock> stocks = new List<Stock>();
        public StockPortfolio(Stock stock)
        {
            stocks.Add(stock);
        }

        public void total()
        {
            int val=0;
            foreach(var stock in stocks)
            {
                val += stock.stockvalue();
            }
            Console.WriteLine("Total value: " + val);
        }
    }*/
}
