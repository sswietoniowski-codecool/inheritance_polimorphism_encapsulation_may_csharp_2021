using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Jan", "Kowalski", 1990, 5000));
            employees.Add(new Manager("Adam", "Nowak", 1990, 5000));

            foreach (var e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
