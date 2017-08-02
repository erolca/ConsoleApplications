using System;

class MainClass
{

    public static void Main()
    {


        int[] intArray = new int[10];
        int arrayLength = intArray.Length;

        Console.WriteLine("arrayLength = " + arrayLength);

        for (int counter = 0; counter < arrayLength; counter++)
        {
            intArray[counter] = counter;
            Console.WriteLine("intArray[" + counter + "] = " + intArray[counter]);
        }

    }

}