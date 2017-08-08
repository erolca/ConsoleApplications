using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

enum orientation : byte
{
    north = 1,
    south = 2,
    east = 3,
    west = 4
}

struct route
{
    public orientation direction;
    public double distance;
}

public class MainClass
{
    public static void Main()
    {
     
    }
}