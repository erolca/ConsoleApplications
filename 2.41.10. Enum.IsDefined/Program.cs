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
        if (Enum.IsDefined(typeof(EmployeeType), "SalesPerson"))
            Console.WriteLine("Yep, we have sales people.");
        else
            Console.WriteLine("No, we have no profits....");
    }
}