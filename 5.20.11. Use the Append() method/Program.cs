using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();

        myStringBuilder.Append("myString");


        myStringBuilder.Append("Here's another string", 0, 4);



        Console.WriteLine(myStringBuilder);
    }
}