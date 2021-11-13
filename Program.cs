using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
           Dog azor = new Dog("Azor");
           Cat mruczek = new Cat("Mruczek");
           azor.MakeSound();
           mruczek.MakeSound();
        }
    }
}
