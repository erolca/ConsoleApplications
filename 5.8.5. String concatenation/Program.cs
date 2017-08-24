using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        string s1 = "A ";
        string s2 = "B";
        string s3 = string.Concat(s1, s2);
        Console.WriteLine(s3);
    }
}