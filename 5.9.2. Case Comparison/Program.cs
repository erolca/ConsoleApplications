using System;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        char smallA = 'a';
        char largeA = 'A';

        Console.WriteLine("a = {0} A = {1}", (int)smallA, (int)largeA);

        string str1 = "This Is A String.";
        string str2 = "This is a string.";

        Console.WriteLine("Case sensitive comparison of str1 and str2 = {0}", String.Compare(str1, str2));
        Console.WriteLine("Case insesitive comparison of str1 and str2 = {0}", String.Compare(str1, str2, true));
    }
}