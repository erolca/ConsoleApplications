using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

[Flags]
enum FileAccess
{
    Read = 1,
    Write = 2,
    ReadWrite = 3
}


public class MainClass
{
    public static void Main()
    {
        FileAccess rw1 = FileAccess.Read | FileAccess.Write;
        Console.WriteLine("rw1 == {0}", rw1);
        FileAccess rw2 = FileAccess.ReadWrite;
        Console.WriteLine("rw2 == {0}", rw2);

        Console.WriteLine("rw1 == rw2? {0}", rw1 == rw2);

        if (rw1 == FileAccess.Read)
            Console.WriteLine("try #1: read permitted");
        else
            Console.WriteLine("try #1: read denied");

        if ((rw2 & FileAccess.Read) != 0)
            Console.WriteLine("try #2: read permitted");
        else
            Console.WriteLine("try #2: read denied");
    }
}