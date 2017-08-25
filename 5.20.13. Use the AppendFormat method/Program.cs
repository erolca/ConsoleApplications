using System;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();

        myStringBuilder.Append("myString");
        myStringBuilder.Append(" ... ");
        int myInt = 1234;
        myStringBuilder.Append(myInt);
        bool myBool = true;
        myStringBuilder.Append(myBool);


        Console.WriteLine(myStringBuilder);
    }
}