﻿using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        string firstName = "Buddy";
        Console.WriteLine("Value of firstName: {0}", firstName);
        Console.WriteLine("firstName has {0} characters.", firstName.Length);
        Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
        Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
        Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
        Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
    }
}