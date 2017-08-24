using System;

class SwitchGoto
{
    public static void Main()
    {

        for (int i = 1; i < 5; i++)
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("In case 1");
                    goto case 3;
                case 2:
                    Console.WriteLine("In case 2");
                    goto case 1;
                case 3:
                    Console.WriteLine("In case 3");
                    goto default;
                default:
                    Console.WriteLine("In default");
                    break;
            }
            Console.WriteLine();
        }
    }
}