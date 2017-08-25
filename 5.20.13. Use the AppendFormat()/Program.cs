using System;
using System.Text;


//5.20.13.	Use the AppendFormat() method to add a formatted string containing a floating point number to myStringBuilder
class MainClass
{
    public static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();
        myStringBuilder.Append("friends");

        float myFloat = 1234.56789f;
        myStringBuilder.AppendFormat("{0, 10:f3}", myFloat);
        Console.WriteLine("myStringBuilder = " + myStringBuilder);

        Console.WriteLine(myStringBuilder);
    }
}