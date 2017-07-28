using System;

class MainClass
{

    public static void Main()
    {

        int[] myArray = new int[2];
        Console.WriteLine("Attempting to access an invalid array element");
        myArray[2] = 1;

    }

}