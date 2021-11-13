using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Manager : Employee
    {
        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary):
            base(firstName, lastName, yearOfBirth, salary)
        {
            Console.WriteLine("Wywołano konstruktor z parametrami z Manager");
        }

        public override decimal GetSalary()
        {
            return Salary * 1.1m;
        }
    }
}
