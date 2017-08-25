using System;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        string replaceStr = "1234";
        string dest = "ABCDEFGHWXYZ";

        dest = dest.Replace("EFGH", replaceStr);

        Console.WriteLine(dest);

    }
}