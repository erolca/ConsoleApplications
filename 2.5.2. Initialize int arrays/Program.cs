using System;

class MainClass
{
    public static void Main()
    {

        int[] intArray = new int[5] { 10, 20, 30, 40, 50 };
        for (int counter = 0; counter < intArray.Length; counter++)
        {
            Console.WriteLine("intArray[" + counter + "] = " +
              intArray[counter]);
        }

    }
}