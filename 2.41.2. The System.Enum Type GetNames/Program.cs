using System;

enum Color
{
    red,
    green,
    yellow
}
enum EmployeeType : byte
{
    Manager = 10,
    Programmer = 1,
    Contractor = 100,
    Developer = 9
}

public class MainClass
{
    public static void Main()
    {
        Color c = Color.red;


        /*	2.41.2.	The System.Enum Type: GetNames*/

        foreach (string s in Enum.GetNames(c.GetType()))
        {
            Console.WriteLine("Name: {0}", s);
        }


        /*2.41.3.	The System.Enum Type: enum value from a string, ignore case*/
 
        c = (Color)Enum.Parse(typeof(Color), "Red", true);
        Console.WriteLine("string value is: {0}", c);

      

        /*2.41.4.	The System.Enum Type: see if a specific value is a defined enum member*/
        bool defined = Enum.IsDefined(typeof(Color), 5);

        Console.WriteLine("5 is a defined value for Color: {0}", defined);

        defined = Enum.IsDefined(typeof(Color), "red");

        Console.WriteLine("c is a defined value for Color: {0}", defined);

        Console.WriteLine(Enum.GetUnderlyingType(typeof(EmployeeType)));


        if (Enum.IsDefined(typeof(EmployeeType), "SalesPerson"))
            Console.WriteLine("Yep, we have sales people.");
        else
            Console.WriteLine("No, we have no profits....");

    }
}
 