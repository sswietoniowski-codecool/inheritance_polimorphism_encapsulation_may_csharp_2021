using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>()
            {
              new Circle(5),
              new Circle(10),
              new Circle(20),
              new Square(5),
              new Square(10),
              new Square(100)
            };

            double totalArea = 0;
            foreach (Shape shape in shapes) {
                totalArea += shape.GetArea();                
            }

            Console.WriteLine($"Total area: {totalArea}");

        }
    }
}
