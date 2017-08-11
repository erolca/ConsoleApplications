using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        byte b1 = 100;
        byte b2 = 250;

        try
        {
            byte sum = unchecked((byte)(b1 + b2));
            Console.WriteLine("sum = {0}", sum);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}