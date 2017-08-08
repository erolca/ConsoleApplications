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

        EmployeeType fred;
        fred = EmployeeType.Developer;

        Console.WriteLine("You are a {0}", fred.ToString());
        Console.WriteLine("Hex value is {0}", Enum.Format(typeof(EmployeeType), fred, "x"));
        Console.WriteLine("Int value is {0}", Enum.Format(typeof(EmployeeType), fred, "D"));

        EmployeeType sally = (EmployeeType)Enum.Parse(typeof(EmployeeType), "Manager");
        Console.WriteLine("Sally is a {0}", sally.ToString());


        /* c = (Color) Enum.Parse(typeof(Color), "Red", true);
        Console.WriteLine("string value is: {0}", c);*/

        Array obj = Enum.GetValues(typeof(EmployeeType));
        Console.WriteLine("This enum has {0} members:", obj.Length);

        if (Enum.IsDefined(typeof(EmployeeType), "SalesPerson"))
            Console.WriteLine("Yep, we have sales people.");
        else
            Console.WriteLine("No, we have no profits....");

    }
}