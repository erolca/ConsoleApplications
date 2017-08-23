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
        EmployeeType Joe = EmployeeType.Developer;
        EmployeeType Fran = EmployeeType.Programmer;

        if (Joe < Fran)
            Console.WriteLine("Joe's value is less than Fran's");
        else
            Console.WriteLine("Fran's value is less than Joe's");

    }
}