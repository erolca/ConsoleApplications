using System;

class MainClass
{
    public static void Main()
    {
        string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Console.WriteLine("str: " + str);

        Console.Write("str.Substring(15): ");
        string substr = str.Substring(15);
        Console.WriteLine(substr);

    }
}
//str: ABCDEFGHIJKLMNOPQRSTUVWXYZ
//str.Substring(15): PQRSTUVWXYZ