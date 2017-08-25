using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();
        myStringBuilder.Append("friends");

        myStringBuilder.Insert(2, "friends, ");
        myStringBuilder.Insert(2, "Romans, ", 3);
        Console.WriteLine("myStringBuilder = " + myStringBuilder);

    }
}