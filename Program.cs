using System;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "James",
                LastName = "Bond",
                YearOfBirth = 1939
            };
            employee.WhoAmI();
            Console.WriteLine(employee.IsAdult());

            Employee secondEmployee = new Employee("Jan", "Kowalski", 1981, 5000);
        }
    }
}
