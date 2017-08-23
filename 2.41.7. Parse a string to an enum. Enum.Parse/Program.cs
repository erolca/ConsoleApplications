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

        EmployeeType sally = (EmployeeType)Enum.Parse(typeof(EmployeeType), "Manager");
        Console.WriteLine("Sally is a {0}", sally.ToString());
    }
}