using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEPhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> squad = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] creatures = Console.ReadLine().Split();
                if (string.Join(" ", creatures) == "Blaze it!")
                    break;
                try
                {
                    if (squad[creatures[0]].Contains(creatures[2]) || creatures[0] == creatures[2])
                        continue;
                    squad[creatures[0]].Add(creatures[2]);
                }
                catch(Exception)
                {
                    squad.Add(creatures[0], new List<string> { creatures[2] });
                }
            }

            foreach (var creature in squad.Keys)
            {
                List<string> copy = new List<string>(squad[creature]);
                foreach (var mate in copy)
                {
                    if (squad.ContainsKey(mate))
                        if (squad[mate].Contains(creature))
                        {
                            squad[creature].Remove(mate);
                            squad[mate].Remove(creature);
                        }
                }
            }

            squad = squad.OrderByDescending(x => x.Value.Count).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var creature in squad.Keys)
            {
                Console.WriteLine(creature + " : " + squad[creature].Count);
            }
        }
    }
}
