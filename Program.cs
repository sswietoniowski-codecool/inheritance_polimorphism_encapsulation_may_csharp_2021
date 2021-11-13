using System;
using System.Collections.Generic;
using DummyLibrary;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Jan", "Kowalski", 1990, 5000)
            {
                RoomNumberNewWay = 5
            };
            Console.WriteLine(manager.RoomNumberNewWay);
            //manager.RoomNumberNewWay = 6;
            Console.WriteLine(manager.RoomNumber);
            //manager.RoomNumber = 5;
        }
    }
}
