using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Circle : Shape
    {
        double radius;
        const double PI = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea() {
            return PI * radius * radius;
        }
    }
}
