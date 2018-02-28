using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "A":
                        phonebook[command[1]] = command[2];
                        break;
                    case "S":
                        Console.WriteLine(phonebook.ContainsKey(command[1]) ? $"{command[1]} ->" +
                            $" {phonebook[command[1]]}" : $"Contact {command[1]} does not exist");
                        break;
                    case "END":
                        return;
                }
            }
        }
    }
}
