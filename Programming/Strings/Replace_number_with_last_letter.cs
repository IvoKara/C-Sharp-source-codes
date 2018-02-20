using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlu_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i = 0;
            while (i < input.Length)
            {
                bool isMaxLen = false;
                int j = i;
                while (input[j] >= '0' && input[j] <= '9')
                {
                    j++;

                    if (j == input.Length)
                    {
                        isMaxLen = true;
                        break;
                    }
                }
                if (isMaxLen)
                    break;
                if (j > i)                
                    input = input.Replace(input.Substring(i, j - i), input[j].ToString());
                
                i++;
            }
            Console.WriteLine(input);
        }
    }
}
