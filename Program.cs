using System;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "James";
            employee.LastName = "Bond";
            employee.YearOfBirth = 1939;
            employee.WhoAmI();
            Console.WriteLine(employee.IsAdult());
        }
    }
}
