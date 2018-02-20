using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder karateMoves = new StringBuilder(Console.ReadLine());
            int reminder = 0;
            for (int i = 0; i < karateMoves.Length; i++)
            {
                if(karateMoves[i] == '>')
                {
                    int j = ++i;
                    while (j < karateMoves.Length - 1 && karateMoves[j] != '>')
                        j++;

                    int givenLen = int.Parse(karateMoves[i].ToString());

                    if (reminder > 0)
                    {
                        givenLen += reminder;
                        reminder = 0;
                    }
                    if (givenLen > j - i)
                    {
                        reminder += givenLen - (j - i);
                        givenLen -= reminder;
                    }
                        
                    karateMoves.Remove(i, givenLen);
                    i--;
                }
            }
            Console.WriteLine(karateMoves);
        }
    }
}
