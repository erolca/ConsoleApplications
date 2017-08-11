using System;

class MainClass
{
    static void Main(string[] args)
    {
        ushort sh = 2000;
        byte sb;

        sb = checked((byte)sh);
        Console.WriteLine("sb: {0}", sb);
    }
}