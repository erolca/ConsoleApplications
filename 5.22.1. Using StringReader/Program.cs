using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        String MyString = "Hello World";

        char[] MyChar = new char[12];

        StringReader MyStringReader = new StringReader(MyString);

        MyStringReader.Read(MyChar, 0, 5);

        Console.WriteLine(MyChar);

        MyStringReader.Close();
    }
}