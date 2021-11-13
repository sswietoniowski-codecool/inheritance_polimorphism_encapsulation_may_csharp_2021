using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Employee : Person
    {
        public Employee()
        {
            Salary = 0;
            Console.WriteLine("Wywołano konstruktor bezparametrowy z Employee");
        }

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) :
            base(firstName, lastName, yearOfBirth)
        {
            //FirstName = firstName;
            ////this._firstName = "";
            //LastName = lastName;
            //YearOfBirth = yearOfBirth;
            Salary = salary;
            Console.WriteLine("Wywołano konstruktor z parametrami z Employee");
        }

        public decimal Salary { get; set; }
    }
}
