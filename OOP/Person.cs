using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_concept
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person() : this("NoName", 1) { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string[] stringInfo) : this(stringInfo[0], int.Parse(stringInfo[1])) { }
    }

    class Employee : Person
    { 
        public double Salary { get; set; }
        public string Job { get; set; }
        public string Branch { get; set; }
        public string Email { get; set; }

        public Employee(string name, int age) : base(name, age) { }
        public Employee(string[] wholeInfo)
        {
            Name = wholeInfo[0];
            Salary = double.Parse(wholeInfo[1]);
            Job = wholeInfo[2];
            Branch = wholeInfo[3];
            if (wholeInfo.Length > 4)
                Email = wholeInfo[4];
            else
                Email = "n/a";
            if (wholeInfo.Length > 5)
                Age = int.Parse(wholeInfo[5]);
            else
                Age = -1;   
        }
        public static void FindBestSalaryJob(List<Employee> employees) 
        {
            Dictionary<string, double> pairs = new Dictionary<string, double>();
            foreach(var employee in employees)
            {
                if(!pairs.ContainsKey(employee.Branch))
                {
                    pairs.Add(employee.Branch, employees.Where(x => x.Branch == employee.Branch).Select(x => x.Salary).Average());
                }
            }
            List<Employee> best = employees.Where(x => x.Branch == pairs.OrderByDescending(y => y.Value).ToDictionary(z => z.Key, z => z.Value).Keys.First()).OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine($"Highest Avarage Salary: {best[0].Branch}");
            foreach(var job in best)
                Console.WriteLine($"{job.Name} {job.Salary:f2} {job.Email} {job.Age}");
        }
    }
}
