using System;

class MainClass
{
    public static void Main()
    {
        int ivar;     // an int variable 
        double dvar;  // a floating-point variable 

        ivar = 100;   // assign ivar the value 100 

        dvar = 100.0; // assign dvar the value 100.0 

        Console.WriteLine("Original value of ivar: " + ivar);
        Console.WriteLine("Original value of dvar: " + dvar);

        Console.WriteLine();            // print a blank line 

        // now, divide both by 3 
        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("ivar after division: " + ivar);
        Console.WriteLine("dvar after division: " + dvar);
    }
}


// output: Original value of ivar: 100
//Original value of dvar: 100

//ivar after division: 33
//dvar after division: 33.3333333333333