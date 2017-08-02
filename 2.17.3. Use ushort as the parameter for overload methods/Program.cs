using System;

class Util
{
    public static void Process(short value)
    {
        Console.WriteLine("short {0}", value);
    }
    public static void Process(ushort value)
    {
        Console.WriteLine("ushort {0}", value);
    }
}

class MainClass
{
    public static void Main()
    {
       /* byte*/ ushort value = 3;
        Util.Process(value);


         value = 21708;
        string[] specifiers = { "G", "C", "D3", "E2", "e3", "F",
                              "N", "P", "X", "000000.0", "#.0"};

        foreach (string specifier in specifiers)
            Console.WriteLine("{0}: {1}", specifier, value.ToString(specifier));
    }
}