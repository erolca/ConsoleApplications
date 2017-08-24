using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        string ans;
        do
        {
            Console.Write("Are you done? [yes] [no] : ");
            ans = Console.ReadLine();
        } while (ans != "yes");
    }
}