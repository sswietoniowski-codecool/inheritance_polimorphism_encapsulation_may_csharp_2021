using System;

namespace csharp_oop_1_demo
{
    public class Person
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;

            Console.WriteLine("Wywołano konstruktor z parametrami z Person");
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() : this("NIEZNANY", "NIEZNANY", 1900)
        {
            Console.WriteLine("Wywołano konstruktor bezparametrowy z Person");
        }

        public void WhoAmI()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"My Name is {LastName}. {FirstName} {LastName}.";
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;
    }
}
