using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Max of int: {0}", int.MaxValue);
        Console.WriteLine("Min of int: {0}", int.MinValue);
        Console.WriteLine("Max of double: {0}", double.MaxValue);
        Console.WriteLine("Min of double: {0}", double.MinValue);
        Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
        Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
        Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
        Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

        /* 2.1.22.	Default values for primitive types
            Type                                Default value
            Reference                           null
            Numeric type or Enum type             0
            char type                             '\0'
            bool type                             false
         
         
         */
    }

}