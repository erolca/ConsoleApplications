using System;

class MainClass
{

    public static void Main()
    {

        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString = String.Join(".", myStrings);


        string myString21 = myString.Substring(3);
        Console.WriteLine("myString.Substring(3) = " + myString21);
        string myString22 = myString.Substring(3, 2);
        Console.WriteLine("myString.Substring(3, 2) = " + myString22);

    }

}