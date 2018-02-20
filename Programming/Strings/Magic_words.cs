using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Console.WriteLine(MagicWords(words[0], words[1]));
        }

        static bool MagicWords(string firstWord, string secondWord)
        {
            Dictionary<char, char> wordChecker = new Dictionary<char, char>();
            if (firstWord.Length != secondWord.Length)
                return false;
            for(int i = 0; i < firstWord.Length; i++)
            {
                try
                {
                    if (wordChecker[firstWord[i]] != secondWord[i])
                        return false;
                }
                catch (KeyNotFoundException)
                {
                    wordChecker.Add(firstWord[i], secondWord[i]);
                }
            }
            return true;
        }
    }
}
