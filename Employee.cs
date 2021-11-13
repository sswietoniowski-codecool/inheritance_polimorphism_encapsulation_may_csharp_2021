namespace csharp_oop_1_demo
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary) :
            base(firstName, lastName, yearOfBirth)
        {
            Salary = salary;

        }
        public decimal Salary { get; set; }


    }
}