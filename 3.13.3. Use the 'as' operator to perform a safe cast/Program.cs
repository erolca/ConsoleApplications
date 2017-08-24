using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        Object someObject = new StringReader("This is a StringReader");

        
        StringReader reader = someObject as StringReader;
        if (reader != null)
        {
            Console.WriteLine("as: someObject is a StringReader");
        }
    }
}

