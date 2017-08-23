using System;

class MainClass
{
    enum Week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturaday, Sunday };

    public static void Main()
    {
        Week i;

        for (i = Week.Monday; i <= Week.Sunday; i++)
            Console.WriteLine(i + " has value of " + (int)i);

    }
}