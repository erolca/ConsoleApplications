using System;

class MainClass
{
    public static void Main()
    {

        char[] charray = { 'A', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };
        string str1 = new string(charray);
        string str2 = "Another string.";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}