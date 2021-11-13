using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Person
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
            //Console.WriteLine("My Name is " + LastName + ". " + FirstName + " " + LastName + ".");
            Console.WriteLine($"My Name is {LastName}. {FirstName} {LastName}.");
        }

        public bool IsAdult() => DateTime.Today.Year - YearOfBirth >= 18;
    }
}
