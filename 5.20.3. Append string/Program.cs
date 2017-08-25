using System;
using System.Text;

class MainClass
{
    static void Main(string[] args)
    {
        StringBuilder MyString = new StringBuilder("Hello");

        MyString.Insert(0, "My");
        MyString.Append("World");

        Console.WriteLine(MyString);

    }
}
//MyHelloWorld