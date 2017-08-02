using System;

class MainClass
{
    public static void Main()
    {
        int value = Int32.Parse("99953");
        Console.WriteLine("{0}", value);


        /*2.9.2.	Use TryParse from int*/

        Console.WriteLine("Please enter an integer and press Enter");
        int numberEntered;
        while (!int.TryParse(Console.ReadLine(), out numberEntered))
        {
            Console.WriteLine("Please try again");
        }
        Console.WriteLine("You entered " + numberEntered.ToString());
    }
}