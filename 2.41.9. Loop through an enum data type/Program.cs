using System;

enum EmployeeType : byte
{
    Manager = 10,
    Programmer = 1,
    Contractor = 100,
    Developer = 9
}

class MainClass
{
    public static void Main(string[] args)
    {
        Array obj = Enum.GetValues(typeof(EmployeeType));
        foreach (EmployeeType e in obj)
        {
            Console.Write("String name: {0}", Enum.Format(typeof(EmployeeType), e, "G"));
            Console.Write(" ({0})", Enum.Format(typeof(EmployeeType), e, "D"));
            Console.Write(" hex: {0}\n", Enum.Format(typeof(EmployeeType), e, "X"));
            Console.WriteLine();
        }

    }
}