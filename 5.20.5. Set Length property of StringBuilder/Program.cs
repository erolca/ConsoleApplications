using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder("test string");
        int length = 0;

        length = sb.Length;
        Console.WriteLine("The result is: '{0}'", sb);
        Console.WriteLine("The length is: {0}", length);

        sb.Length = 4;
        length = sb.Length;
        Console.WriteLine("The result is: '{0}'", sb);
        Console.WriteLine("The length is: {0}", length);

        sb.Length = 20;
        length = sb.Length;
        Console.WriteLine("The result is: '{0}'", sb);
        Console.WriteLine("The length is: {0}", length);
    }
}

/*
 * The result is: 'test string'
The length is: 11
The result is: 'test'
The length is: 4
The result is: 'test                '
The length is: 20
*/