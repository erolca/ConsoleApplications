using System;

class Example
{
    public static void Main()
    {
        byte b;
        char ch;

        b = 88; // ASCII code for X 
        ch = (char)b;
        Console.WriteLine("ch after assigning 88: " + ch);

    }
}