using System;

namespace csharp_oop_1_demo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes {Sound}");
        }
    }
}