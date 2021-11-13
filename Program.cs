using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Employee employee = new Employee("Jan", "Kowalski", 1981, 5000);
            Person person = new Person("Anna", "Nowak", 1982);

            people.Add(employee);
            people.Add(person);

            foreach (var p in people)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}"); 
            }
        }
    }
}
