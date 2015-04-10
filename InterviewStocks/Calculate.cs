using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStocks
{
    class Calculate
    {
        public void CalculateStocks(int[] stocks)
        {


            int buyPrice, buyTime, sellPrice, sellTime, profit;

            buyPrice = stocks[0];
            buyTime = 0;
            sellPrice = stocks[1];
            sellTime = 1;
            profit = sellPrice - buyPrice;


            Print(buyPrice, buyTime, sellPrice, sellTime, profit);
            int k = 0;
            for (int i = k; i < (stocks.Length-1); i++)
            {
                int tempBuyPrice, tempBuyTime, tempSellPrice, tempSellTime, tempProfit;
                tempBuyPrice = stocks[i];
                tempBuyTime = i;
                for(int j = i+1; j < stocks.Length; j++)
                {
                    tempSellPrice = stocks[j];
                    tempSellTime = j;

                    tempProfit = tempSellPrice - tempBuyPrice;

                    if (tempProfit > profit)
                    {
                        buyPrice = tempBuyPrice;
                        buyTime = tempBuyTime;
                        sellPrice = tempSellPrice;
                        sellTime = tempSellTime;
                        profit = tempProfit;

                        Print(buyPrice, buyTime, sellPrice, sellTime, profit);
                    }

                }
            }
        }

        public void Print(int buyPrice, int buyTime, int sellPrice, int sellTime, int profit)
        {
            Console.WriteLine("Buy price = £" + buyPrice + " at " + GetTime(buyTime) + " : Sell price = £" + sellPrice + " at " + GetTime(sellTime) + " : Profit = £" + profit);
           
        }

        public string GetTime(int time)
        {
            string i = "";

            //set original time to yesterday at 09:30
            DateTime origin = DateTime.Now;
            //Console.WriteLine(origin);
            origin = origin.AddDays(-1);
            //Console.WriteLine(origin);
            TimeSpan ts = new TimeSpan(09, 30, 00);
            origin = origin.Date + ts;
            Console.WriteLine(origin);

            //amend time by the minutes states in index
            origin = origin.AddMinutes(time);
            i = origin.ToString();
            //Console.WriteLine(i);
            return i;
        }
           
    }
}
