using System;

class MainClass
{
    public static void Main()
    {
        int x = 21;

        string str = x.ToString("X");
        Console.WriteLine(str);

        str = x.ToString("D12");
        Console.WriteLine(str);


       /* 2.12.1.To specify a long type, use either the l or L suffix. For example:*/

        long lVal = 0x7FFFFFL;            // Long value specified as hex constant
        Console.WriteLine(lVal);

        /*2.12.2.	Autobox and unbox long value*/

        long MyLong = 10051234;
        object MyObject = MyLong;
        long MyLong2 = (long)MyObject;

    }
}