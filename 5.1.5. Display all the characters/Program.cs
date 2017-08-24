using System;

class MainClass
{
    //5.1.5.	Display all the characters in myString using a for loop
    public static void Main()
    {
        string myString = "To be or not to be";


        for (int count = 0; count < myString.Length; count++)
        {
            Console.WriteLine("myString[" + count + "] = " + myString[count]);
        }

    }

}