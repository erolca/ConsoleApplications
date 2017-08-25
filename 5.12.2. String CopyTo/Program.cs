using System;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string source = "ABCD";
        char[] dest = { '1', '2', '3', '4', '5', '6', '7', '8' };

        Console.Write("Char array before = ");
        Console.WriteLine(dest);

        // copy substring into char array
        source.CopyTo(0, dest, 4, source.Length);

        Console.Write("Char array after = ");
        Console.WriteLine(dest);

        // copy back into source string
        source = new String(dest);

        Console.WriteLine("New source = {0}\n", source);

    }
}