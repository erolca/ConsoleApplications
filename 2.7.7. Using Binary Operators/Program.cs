using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Division
{
    static void Main()
    {
        int numerator;
        int denominator;
        int quotient;
        int remainder;
        


        System.Console.Write("Enter the numerator: ");
        numerator = int.Parse(System.Console.ReadLine());
        
        System.Console.Write("Enter the denominator: ");
        denominator = int.Parse(System.Console.ReadLine());

        quotient = numerator / denominator;
        remainder = numerator % denominator;

        System.Console.WriteLine("{0} / {1} = {2} with remainder {3}", numerator, denominator, quotient, remainder);


        System.Console.WriteLine("Enter the numerator");
        numerator = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Enter the denomitor");
         denominator = Convert.ToInt32(System.Console.ReadLine());


        quotient = numerator / denominator;
        remainder = numerator % denominator;

        System.Console.WriteLine("{0} / {1} = {2} with remainder {3}", numerator, denominator, quotient, remainder);


    }
}