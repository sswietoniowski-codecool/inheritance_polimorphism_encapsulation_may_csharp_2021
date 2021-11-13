using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public void WhoAmI()
        {
            //Console.WriteLine("My Name is " + LastName + ". " + FirstName + " " + LastName + ".");
            Console.WriteLine($"My Name is {LastName}. {FirstName} {LastName}.");
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;

        public decimal Salary { get; set; }
    }
}
