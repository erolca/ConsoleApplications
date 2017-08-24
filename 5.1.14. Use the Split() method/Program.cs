using System;

class MainClass
{

    public static void Main()
    {
        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString9 = String.Join(".", myStrings);
        myStrings = myString9.Split('.');
        foreach (string mySplitString in myStrings)
        {
            Console.WriteLine("mySplitString = " + mySplitString);
        }
    }

}