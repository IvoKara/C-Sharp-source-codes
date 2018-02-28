using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentIndex = int.Parse(Console.ReadLine());
            int hitPower = 1;
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Supernova":
                        foreach (var i in sequence)
                            Console.Write(i + " ");
                        return;

                    case "left":
                        for (int i = 1; i <= int.Parse(command[1]); i++)
                        {
                            if (currentIndex == 0)
                            {
                                currentIndex = sequence.Count;
                                hitPower++;
                            }
                            sequence[--currentIndex]-=hitPower;
                        }
                        break;
                    case "right":
                        for (int i = 1; i <= int.Parse(command[1]); i++)
                        {
                            if (currentIndex == sequence.Count - 1)
                            {
                                currentIndex = -1;
                                hitPower++;
                            }
                            sequence[++currentIndex] -= hitPower;
                        }
                        break;
                }
            }
        }
    }
}
