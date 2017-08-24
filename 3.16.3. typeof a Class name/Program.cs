using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        Object someObject = new StringReader("This is a StringReader");

        if (typeof(StringReader) == someObject.GetType())
        {
            Console.WriteLine("typeof: someObject is a StringReader");
        }

    }
}