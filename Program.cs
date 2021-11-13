using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Reksio"));
            animals.Add(new Dog("Pluto"));
            animals.Add(new Cat("Filek"));

            foreach (var animal in animals)
            {
                if (animal is Cat)
                {
                    Console.WriteLine($"{animal.Name} is cat.");
                }
                else if (animal is Dog)
                {
                    Console.WriteLine($"{animal.Name} is dog.");
                }
                animal.MakeSound();
            }
        }
    
    }
}
