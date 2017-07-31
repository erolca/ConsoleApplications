using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // Local variables are declared and initialized as so:
        // dataType varName = initialValue;
        int myInt = 0;

        string myString;
        myString = "This is my character data";

        // Declare 3 bools on a single line.
        bool b1 = true, b2 = false, b3 = b1;

        System.Boolean b4 = false;

        System.Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
            myInt, myString, b1, b2, b3, b4);
    }

}