using System;

using System.Globalization;

class MainClass
{
    static void Main(string[] args)
    {
        // Get the type code of C# int.
        int theInt = 65;
        Console.WriteLine("Type code of int is: {0}", theInt.GetTypeCode());

        Console.WriteLine("Casting System.Int32 to System.Char");
        char theChar = (char)theInt;

        Console.WriteLine("Type code int converted to char is: {0}", theChar.GetTypeCode());
        Console.WriteLine("Value of converted char: {0}", theChar);

    }
}