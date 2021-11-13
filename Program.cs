using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipt receipt = new Receipt();
            receipt.AddItem(new OrderItem("bread", 5, 3.5m));
            receipt.AddItem(new OrderItemWithPackage("milk", 5, 2.2m, "bottle", 
                1));
            receipt.Display();
        }
    }
}
