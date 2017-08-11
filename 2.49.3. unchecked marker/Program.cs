using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // Declare two shorts to add.
        short numb1 = 30000, numb2 = 30000;
        // This will not throw an exception.
        unchecked
        {
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}",
                numb1, numb2, answer);
        }

    }

    static int Add(int x, int y)
    {
        return x + y;
    }
}