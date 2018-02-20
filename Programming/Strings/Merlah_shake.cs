using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainString = Console.ReadLine();
            string label = Console.ReadLine();
            
            while (true)
            {
                try
                {
                    mainString = mainString.Remove(mainString.IndexOf(label), label.Length);
                    mainString = mainString.Remove(mainString.LastIndexOf(label), label.Length);
                    Console.WriteLine("Shaked it.");
                    label = label.Remove(label.Length / 2, 1);
                    if (label.Length == 0)
                        break;
                }
                catch (Exception)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                
            }
            Console.WriteLine(mainString);
        }
    }
}
