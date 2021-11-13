using System;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee employee = new Employee("James", "Bond", 1939)
            // {
            //     FirstName = "James",
            //     LastName = "Bond",
            //     YearOfBirth = 1939
            // };
            // // employee.FirstName = "James";
            // // employee.LastName = "Bond";
            // // employee.YearOfBirth = 1939;
            // employee.WhoAmI();
            // Console.WriteLine(employee.IsAdult());

            Employee secondEmployee = new Employee("Jan", "Kowalski", 1989, 5000);
            Console.WriteLine(secondEmployee.Salary);
            Person person = new Employee("Anna", "Nowak", 1982, 5000);
        }
    }
}
