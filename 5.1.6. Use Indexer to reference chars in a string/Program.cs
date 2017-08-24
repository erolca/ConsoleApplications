using System;

class MainClass
{

    public static void Main()
    {
        string myString = "To be or not to be";


        for (int count = 0; count < myString.Length; count++)
        {
            Console.WriteLine("myString[" + count + "] = " + myString[count]);
        }

    }

}