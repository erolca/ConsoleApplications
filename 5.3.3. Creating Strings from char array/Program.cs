using System;

class MainClass
{
    static void Main(string[] args)
    {
        char[] MyChar2 = { 'H', 'e', 'l', 'l', 'o', '\0' };

        char[] MyChar3 = new char[6];

        MyChar3[0] = 'H';
        MyChar3[1] = 'e';
        MyChar3[2] = 'l';
        MyChar3[3] = 'l';
        MyChar3[4] = 'o';
        MyChar3[5] = '\0';

        Console.WriteLine(MyChar3);
        Console.WriteLine(MyChar2);
    }
}