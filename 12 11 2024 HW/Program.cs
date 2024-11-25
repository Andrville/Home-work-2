using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    enum TransactionType
    {
        Buy, Sell
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input transaction nominal-");
            int transactionNominal = int.Parse(Console.ReadLine());

            Console.WriteLine("Input trade price-");
            float tradePrice = float.Parse(Console.ReadLine());


            Console.WriteLine("Input transaction type- Buy, Sell");
            string transType = Console.ReadLine();

            //trnsType
            int trnsType = transType == "Buy" ? 1 : -1;

            //Current value
            var CV = transactionNominal * trnsType * tradePrice;
            Console.WriteLine($"Current value is {CV}");

            //booked price
            Console.WriteLine("What is booked price?");
            float bookedPrice = float.Parse(Console.ReadLine());
            float profitLossSale = transType == "sell" ? 1 : 0;
            float profitLoss = ((tradePrice - bookedPrice) * transactionNominal) * profitLossSale;

            Console.WriteLine($"profit loss is {profitLoss}");

            Console.ReadKey();

        }
    }
}

