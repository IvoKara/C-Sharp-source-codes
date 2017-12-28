using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int label = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] wow = new int[6];
            int times = 0;
            for (wow[0] = 0; wow[0] <= 9; wow[0]++)
                for (wow[1] = 0;  wow[1] <= 9; wow[1]++)
                    for (wow[2] = 0; wow[2] <= 9; wow[2]++)
                        for (wow[3] = 'a'; wow[3] <= 'z'; wow[3]++)
                            for (wow[4] = 'a'; wow[4] <= 'z'; wow[4]++)
                                for (wow[5] =0; wow[5] <= 9; wow[5]++)
                                {
                                    if(wow.Sum() == label)
                                    {
                                        for (int i = 0; i < 6; i++)
                                        {
                                            if(i>2 && i<5)
                                                Console.Write((char)wow[i]);
                                            else
                                                Console.Write(wow[i]);
                                        }
                                        Console.Write(' ');
                                        times++;
                                        if (times == n)
                                            return;
                                        break;
                                    }
                                }


        }
    }
}
