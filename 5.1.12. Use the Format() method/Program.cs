using System;

class MainClass
{

    public static void Main()
    {

        float myFloat = 1234.56789f;
        string myString8 = String.Format("{0, 10:f3}", myFloat);
        Console.WriteLine("String.Format(\"{0, 10:f3}\", myFloat) = " + myString8);
    }

}