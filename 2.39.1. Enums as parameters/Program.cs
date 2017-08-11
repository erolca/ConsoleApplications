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
    public static void myFunction(EmployeeType e)
    {
        switch (e)
        {
            case EmployeeType.Contractor:
                Console.WriteLine("EmployeeType.Contractor");
                break;
            case EmployeeType.Programmer:
                Console.WriteLine("EmployeeType.Programmer");
                break;
            case EmployeeType.Manager:
                Console.WriteLine("EmployeeType.Manager");
                break;
            case EmployeeType.Developer:
                Console.WriteLine("EmployeeType.Developer");
                break;
            default: break;
        }
    }
    public static void Main(string[] args)
    {

        EmployeeType fred;
        fred = EmployeeType.Developer;
        myFunction(fred);

    }
}