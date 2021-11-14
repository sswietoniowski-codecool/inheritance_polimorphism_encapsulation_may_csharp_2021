using System;
using System.Collections.Generic;

namespace csharp_oop_1_demo
{
    public class Receipt
    {
        private List<OrderItem> items = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        public void Display()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.GetValue();
            }

            Console.WriteLine($"Order value: {total} PLN");
        }
    }
}