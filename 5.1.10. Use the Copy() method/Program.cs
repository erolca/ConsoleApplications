using System;

class MainClass
{

    public static void Main()
    {

        string myString4 = "string4";
        Console.WriteLine("myString4 = " + myString4);
        Console.WriteLine("Copying myString4 to myString7 using Copy()");
        string myString7 = String.Copy(myString4);
        Console.WriteLine("myString7 = " + myString7);
    }

}
/*
 * myString4 = string4
Copying myString4 to myString7 using Copy()
myString7 = string4
*/