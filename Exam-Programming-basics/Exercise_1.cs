using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double investUSD = double.Parse(Console.ReadLine());
            double BTCpayment = double.Parse(Console.ReadLine());
            double BTC = investUSD / BTCpayment;
            int sashoti = int.Parse((Console.ReadLine()));
            double tax = BTC * (sashoti * 1024) / 100000000;
            BTC -= tax;
            double progPayment = BTC * 0.1;
            tax *= BTCpayment;
            BTC -= progPayment;
            Console.WriteLine($"Total bitcoin after expenses: {BTC:f5} BTC");
            Console.WriteLine($"Tax payed: {tax:f2} USD");
            Console.WriteLine($"Programmer`s payment: {progPayment:f5} BTC");
        }
    }
}
