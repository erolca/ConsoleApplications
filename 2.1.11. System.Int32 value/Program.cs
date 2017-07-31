using System;
/*
 CTS Type Name          C# Alias                   Description

System.Object          Object                      Base class for all CTS types

System.String          String                     String

System.Sbyte           Sbyte                      Signed 8-bit byte

System.Byte            Byte                       Unsigned 8-bit byte

System.Int16           Short                      Signed 16-bit value

System.UInt16          Ushort                     Unsigned 16-bit value

System.Int32           Int                        Signed 32-bit value

System.UInt32          Uint                       Unsigned 32-bit value

System.Int64           Long                       Signed 64-bit value

System.UInt64          Ulong                      Unsigned 64-bit value

System.Char            Char                       16-bit Unicode character

System.Single          Float                      IEEE 32-bit float

System.Double          Double                     IEEE 64-bit float

System.Boolean         Bool                       Boolean value (true/false)

System.Decimal         Decimal                    128-bit data type
     */
class MainClass
{
    public static void Main(string[] args)
    {
        System.Int32 intA = 1001;
        System.Int32 intB = 1000;

        if (intA == intB)
            Console.WriteLine("Same value!\n");
        else
            Console.WriteLine("Not the same value!\n");
        Console.WriteLine();

        /*	2.1.12.	MaxValue/MinValue*/

        Console.WriteLine("Max for an UInt16 is: {0}", UInt16.MaxValue);
        Console.WriteLine("Min for an UInt16 is: {0}", UInt16.MinValue);
       
        Console.WriteLine();

        /* 2.1.13.System.UInt16 value*/
        System.UInt16 myUInt16 = 30000;
        Console.WriteLine("Your value is: {0}", myUInt16.ToString());
        Console.WriteLine("I am a: {0}", myUInt16.GetType().ToString());
        Console.WriteLine();


        /*2.1.14. bool: False / True string*/
        Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
        Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        Console.WriteLine();

        /*2.1.15. ulong: Max / Min value*/
        Console.WriteLine("-> ulong.MaxValue: {0}", ulong.MaxValue);
        Console.WriteLine("-> ulong.MinValue: {0}\n", ulong.MinValue);
        Console.WriteLine();

        /*2.1.16.	Parsing strings to create data types*/
        bool myBool = bool.Parse("True");
        Console.WriteLine("-> Value of myBool: {0}", myBool);
        Console.WriteLine();

        /*2.1.17.Parsing strings to create data types: int*/
        int myInt = int.Parse("8");
        Console.WriteLine("-> Value of myInt: {0}", myInt);
        Console.WriteLine();

        /*2.1.18.	Parsing strings to create data types: char*/
        char myChar = char.Parse("w");
        Console.WriteLine("-> Value of myChar: {0}\n", myChar);
        Console.WriteLine();
    }

}


   

}
 
 
 