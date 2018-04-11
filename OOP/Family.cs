using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_concept
{
    class Family
    {
        private List<Person> members = new List<Person>(); //{ get; set; }

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void PrintAllMembers()
        {
            foreach (var member in members.OrderBy(x => x.Name).ThenBy(x => x.Age))
            {
                Console.WriteLine($"{member.Name} {member.Age}");
            }
        }

        public void PrintOlders(int than)
        {
            foreach (var member in members.OrderBy(x => x.Name).ThenBy(x => x.Age))
            {
                if(member.Age >= than)
                    Console.WriteLine($"{member.Name}  - {member.Age}");
            }
        }
    }
}
