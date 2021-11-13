using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_oop_1_demo
{
    class Employee : Person
    {
        public Employee()
        {
            Salary = 0;
            Console.WriteLine("Wywołano konstruktor bezparamtrowy z Employee");
        }

        public decimal Salary { get; set; }
    }
}
