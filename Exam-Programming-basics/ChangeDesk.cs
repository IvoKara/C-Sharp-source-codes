using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDesk
{
    class Program
    {
        static void Main(string[] args)
        {
            string currency = Console.ReadLine();
            double euro = double.Parse(Console.ReadLine());
            var minXRP = 80;
            var minBTC = 0.001;
            var minETH = 0.0099;
            if (euro > 1000)
                euro += euro * 0.1;
            double coins = 0.0;
            if (currency == "ETH")
            {
                coins = euro / 250;
                if (coins < minETH)
                {
                    Console.WriteLine("Insufficient funds");
                    return;
                }
                Console.WriteLine($"Successfully purchased {coins:f3} ETH");
            }
            else if (currency == "XRP")
            {
                coins = euro / 0.22;
                if (coins < minXRP)
                {
                    Console.WriteLine("Insufficient funds");
                    return;
                }
                else if (coins > 1000 && coins < 2500)
                    coins += 0.05 * coins;
                else if (coins >= 2500)
                    coins += coins * 0.1;
                Console.WriteLine($"Successfully purchased {coins:f3} XRP");
            }
            else if (currency == "BTC")
            {
                coins = euro / 6400;
                if (coins < minBTC)
                {
                    Console.WriteLine("Insufficient funds");
                    return;
                }
                else if (coins > 10)
                    coins += 0.02 * coins;
                Console.WriteLine($"Successfully purchased {coins:f3} BTC");
            }
            else
            {
                Console.WriteLine($"EUR to {currency} is not supported.");
                return;
            }
               
                
        }
    }
}
