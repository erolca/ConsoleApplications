using System;
using System.Collections.Generic;
using System.Text;

class MainClass
{
    static void Main(string[] args)
    {
        SomeClass someObject = new SomeClass();

        if (someObject.GetType() == typeof(SomeClass))
        {
            Console.WriteLine("We have a SomeClass object here");
        }

    }
}

class SomeClass
{
}