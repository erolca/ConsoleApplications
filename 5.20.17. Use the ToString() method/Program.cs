using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();


        myStringBuilder.Append("friends");

        string myString2 = myStringBuilder.ToString();
        Console.WriteLine("myString2 = " + myString2);
    }
}