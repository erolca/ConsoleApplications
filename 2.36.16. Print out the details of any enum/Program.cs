using System;
using System.Collections.Generic;
using System.Text;

enum EmpType : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}

class Program
{
    static void Main(string[] args)
    {
        EmpType e2 = EmpType.Contractor;
        DayOfWeek day = DayOfWeek.Friday;
        ConsoleColor cc = ConsoleColor.Black;
        EvaluateEnum(e2);
        EvaluateEnum(day);
        EvaluateEnum(cc);
    }
    static void EvaluateEnum(System.Enum e)
    {
        Console.WriteLine("=> Information about {0}", e.GetType().Name);
        Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
        Array enumData = Enum.GetValues(e.GetType());
        Console.WriteLine("This enum has {0} members.", enumData.Length);
        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
        }
    }
}