using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewStocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stocks = new int[] { 11, 5, 4, 6, 5, 3, 8, 2, 3, 1 };

            Calculate test = new Calculate();
            test.CalculateStocks(stocks);
            //test.GetTime(1);
            Console.ReadLine();







        }
    }
}
