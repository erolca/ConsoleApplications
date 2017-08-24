using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{

    public static void Main()
    {

        int total = 0;
        int counter = 0;

        myLabel:
        counter++;
        total += counter;

        if (counter < 5)
        {
            System.Console.WriteLine(counter);
            goto myLabel;
        }
    }
}