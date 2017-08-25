using System;
using System.Text;

class MainClass
{
    static void Main(string[] args)
    {
        string MyString = @"C:\MyFiles";
        Console.WriteLine(MyString);

         MyString = "c:\\Program Files";
        Console.WriteLine(MyString);

        MyString = " \"Question\" ";
        Console.WriteLine(MyString);

        string s3 = "Hello\tThere\tAgain";
        Console.WriteLine(s3);
        Console.WriteLine("Everyone loves \"Hello World\"");
        Console.WriteLine("C:\\MyApp\\bin\\debug");
        Console.WriteLine("All finished.\n\n\n");

        System.String strFixed = "This is how I began life";
        Console.WriteLine(strFixed);
        string upperVersion = strFixed.ToUpper();
        Console.WriteLine(strFixed);
        Console.WriteLine("{0}\n\n", upperVersion);


        System.Console.WriteLine('\'');
    }
}