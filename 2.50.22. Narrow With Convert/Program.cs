using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        byte myByte = 0;
        int myInt = 200;
        myByte = Convert.ToByte(myInt);
        Console.WriteLine("Value of myByte: {0}", myByte);
    }

}