using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrBuilder_commands
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder myStringBuilder = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split(' ');
            
            switch (command[0])
            {
                case "Remove":
                    myStringBuilder.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    break;
                case "Insert":
                    myStringBuilder.Insert(int.Parse(command[1]), command[2]);
                    break;
                case "Replace":
                    myStringBuilder.Replace(command[1], command[2]);
                    break;
                case "Append":
                    myStringBuilder.Append(command[1]);
                    break;
            }
            Console.WriteLine(myStringBuilder);
        }
    }
}
