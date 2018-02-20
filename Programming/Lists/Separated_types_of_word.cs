using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_bla_bla
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] {',', ' ', ';', ':', '.', '!', \
                '(', ')', '\"', '\'', '\\', '/', '[', ']' }).ToList();
            text.RemoveAll(x => x == "");
            List<string> lower = new List<string>();
            List<string> upper = new List<string>();
            List<string> mixed = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                string currentWord = text[i];
                bool isMixed = false;
                for (int j = 0; j < currentWord.Length; j++)
                {
                    bool isLetter = Char.IsLetter(currentWord[j]);
                    if (!isLetter)
                    {
                        mixed.Add(currentWord);
                        isMixed = true;
                        break;
                    }
                }
                if (isMixed)
                    continue;

                if (currentWord == currentWord.ToLower())
                    lower.Add(currentWord);
                else if (currentWord == currentWord.ToUpper())
                    upper.Add(currentWord);
                else
                    mixed.Add(currentWord);
                   
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");

        }
    }
}
