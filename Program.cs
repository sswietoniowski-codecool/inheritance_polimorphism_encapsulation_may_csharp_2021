using System;
using System.Collections.Generic;
using DummyLibrary;

namespace csharp_oop_1_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jan", "Kowalski", 1990);
            //person.LastName = "Nowak";

            DummyPublic dummy1 = new DummyPublic();
//            DummyInternal dummy2 = new DummyInternal();

            // protected internal

            // private protected
        }
    }
}
