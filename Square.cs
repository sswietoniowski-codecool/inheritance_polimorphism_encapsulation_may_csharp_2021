using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Square : Shape
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

         public override double GetArea() {
            return side * side;
        }
        
    }
}
