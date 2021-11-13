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
            people.Add(new Person("Adam", "Nowak", 2015));

            foreach (var p in people)
            {
                //Console.WriteLine($"{p.FirstName} {p.LastName}");

                //Console.WriteLine(p.GetType());

                //if (p.GetType() == typeof(Employee))
                //{
                //    Employee e1 = (Employee)p;
                //    Console.WriteLine(e1.Salary);
                //}

                //if (p is Employee e)
                //{
                //    Console.WriteLine(e.Salary);
                //}

                //// Employee e2 = (Employee)p
                //Employee e2 = p as Employee;
                //Console.WriteLine(e2);
                PrintHello(p);
            }
        }

        private static void PrintHello(Person person)
        {
            if (person.IsAdult())
            {
                Console.WriteLine("Witaj w sklepie monopolowym");
            }
            else
            {
                Console.WriteLine("Witaj w sklepie z zabawkami");
            }
        }
    }
}
