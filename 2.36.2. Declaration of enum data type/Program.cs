using System;

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum MyEnum
{
    A
}
class Constants
{
    public const MyEnum value3 = MyEnum.A;
}


class MainClass
{
    static void Main(string[] args)
    {
        DaysOfWeek Today = DaysOfWeek.Friday;

        Console.WriteLine(Today);

        /*	2.36.3.	Define constants with const keywords and enum*/

        Console.WriteLine("{0}", Constants.value3);
    }
}
 