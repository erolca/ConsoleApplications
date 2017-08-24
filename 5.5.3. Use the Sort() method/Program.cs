using System;

class MainClass
{

    public static void Main()
    {

        string[] stringArray = { "t", "i", "a", "test", "abc123", "abc345" };
        Array.Sort(stringArray);
        Console.WriteLine("Sorted stringArray:");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine("stringArray[" + i + "] = " + stringArray[i]);
        }


        //otherway
        foreach(string s in stringArray)
        {

            Console.WriteLine(" = " + s);


        }
    }

}