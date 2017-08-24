using System;

class MainClass
{

    public static void Main()
    {
        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString = String.Join(".", myStrings);

        string myString10 = myString.Insert(6, "A, ");
        Console.WriteLine("myString.Insert(6, \"A, \") = " + myString10);
        string myString11 = myString10.Remove(14, 7);
        Console.WriteLine("myString10.Remove(14, 7) = " + myString11);
        string myString12 = myString11.Replace(',', '?');
        Console.WriteLine("myString11.Replace(',', '?') = " + myString12);
        string myString13 = myString12.Replace("to be", "Or not to be A");
        Console.WriteLine("myString12.Replace(\"to be\", \"Or not to be A\") = " + myString13);
    }

}