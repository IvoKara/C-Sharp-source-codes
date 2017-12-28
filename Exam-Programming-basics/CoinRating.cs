using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRating
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double doge = 0.0;
            int dogePeple = 0;
            double iota = 0.0;
            int iotaPeple = 0;
            double neo = 0.0;
            int neoPeple = 0;
            double estd = 0.0;
            int estdPeple = 0;
            for (int i = 0; i < n; i++)
            {
                string currency = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (currency == "DOGE")
                {
                    doge += AddTo(0.07, money);
                    dogePeple++;
                }
                else if (currency == "IOTA")
                {
                    iota += AddTo(1.44, money);
                    iotaPeple++;
                }
                else if (currency == "NEO")
                {
                    neo += AddTo(28.5, money);
                    neoPeple++;
                }
                else
                {
                    estd += AddTo(25.0, money);
                    estdPeple++;
                }
            }
            double all = iota + neo + estd + doge;
            Console.WriteLine($"Total votes = {n}, Money in market = {all:f2} EUR");
            Console.WriteLine($"DOGE's contribution: {Math.Round((doge/all)*100,2):f2}%; People who use DOGE: {dogePeple}");
            Console.WriteLine($"IOTA's contribution: {Math.Round((iota / all) * 100,2):f2}%; People who use IOTA: {iotaPeple}");
            Console.WriteLine($"NEO's contribution: {Math.Round((neo / all) * 100,2):f2}%; People who use NEO: {neoPeple}");
            Console.WriteLine($"ESTD's contribution: {Math.Round((estd / all) * 100,2):f2}%; People who use ESTD: {estdPeple}");
        }

        static double AddTo(double currency, double money)
        {
            return currency * money;
        }
    }
}
