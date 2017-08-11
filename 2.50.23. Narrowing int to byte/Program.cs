using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        byte myByte = 0;
        int myInt = 300;
        myByte = (byte)myInt;
        Console.WriteLine("Value of myByte: {0}", myByte);
    }

}