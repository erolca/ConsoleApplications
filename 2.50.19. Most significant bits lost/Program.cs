using System;

class MainClass
{
    static void Main(string[] args)
    {
        ushort sh = 2000;
        byte sb;

        sb = unchecked((byte)sh);
     //    sb = (byte)sh;
        Console.WriteLine("sb: {0}", sb);
    }
}