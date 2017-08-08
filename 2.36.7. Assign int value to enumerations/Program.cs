using System;

enum Values
{
    A = 1,
    B = 5,
    C = 3,
    D = 42
}

enum Color
{
    Green,
    Yellow,
    Red
}

class MainClass
{


    enum Week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturaday, Sunday };
    public static void Main()
    {
        Values d = Values.D;
        int i = (int)d;
        Console.WriteLine("d is {0}", d);
        Console.WriteLine("i is {0}", i);

        Values v = (Values)2;
        int ival = (int)v;

        /*2.36.11.	Loop through the enum data type*/
       
        Week gun;
        for(gun=Week.Monday;gun <= Week.Sunday;gun++)
            Console.WriteLine(gun + " has value of " + (int)gun);


        /*  2.36.13.Assign enum value from a member and variable*/
        Color t1 = Color.Red;
        Color t2 = Color.Green;
        Color t3 = t2;

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);

    }
}