using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte [{sbyte.MinValue}...{sbyte.MaxValue}]");  //
            Console.WriteLine($"byte [{byte.MinValue}...{byte.MaxValue}]");     //0...255
            Console.WriteLine($"short [{short.MinValue}...{short.MaxValue}]");  //-32 768...32 767
            Console.WriteLine($"ushort [{ushort.MinValue}...{short.MaxValue}]");
            Console.WriteLine($"int [{int.MinValue}...{int.MaxValue}]");
            Console.WriteLine($"unit [{uint.MinValue}...{uint.MaxValue}]");
            Console.WriteLine($"long [{long.MinValue}...{long.MaxValue}]");
            Console.WriteLine($"ulong [{ulong.MinValue}...{ulong.MaxValue}]");
        }
    }
}
