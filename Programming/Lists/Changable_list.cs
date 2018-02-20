using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changable_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> changableList = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                switch(command[0])            
                {
                    case "Delete":
                        changableList.RemoveAll(x => x == int.Parse(command[1]));
                        break;
                    case "Insert":
                        changableList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Odd": 
                        Console.WriteLine(string.Join(" ", changableList.Where(x => x % 2 != 0)));
                        return;
                    case "Even":
                        Console.WriteLine(string.Join(" ", changableList.Where(x => x % 2 == 0)));
                        return;
                }
                
            }
            
        }
    }
}
