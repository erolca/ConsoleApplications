using System;

class MainClass
{

    public static void Main()
    {
        string myString4 = String.Concat("A, ", "B");
        Console.WriteLine("String.Concat(\"A, \", \"B\") = " + myString4);
        string myString5 = String.Concat("A, ", "B, ", "and countrymen");
        Console.WriteLine("String.Concat(\"A, \", \"B, \", " + "\"and countrymen\") = " + myString5);
    }

}

//String.Concat("A, ", "B") = A, B
//String.Concat("A, ", "B, ", "and countrymen") = A, B, and 