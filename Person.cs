using System;

namespace csharp_oop_1_demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }
        

        public void WhoAmI()
        {
            Console.WriteLine($"My Name is {LastName}. {FirstName} {LastName}.");
        }

        public bool IsAdult() => (DateTime.Now.Year - YearOfBirth) >= 18;
    }
}