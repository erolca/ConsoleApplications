using System;

enum Color
{
    Green,
    Yellow,
    Red
}

enum PlanetPeriods
{
    Mercury = 8,
    Venus = 2,
    Earth = 3,
    Mars = 6
}

enum Planets
{
    Mercury = 1,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune,
    Pluto
}

class MainClass
{
    static void Main()
    {
        Color t1 = Color.Green;
        Color t2 = Color.Yellow;
        Color t3 = Color.Red;

        Console.WriteLine("{0},\t{1}", t1, (int)t1);
        Console.WriteLine("{0},\t{1}", t2, (int)t2);
        Console.WriteLine("{0},\t{1}\n", t3, (int)t3);
        /*2.37.2.	Assign int value to all elements in an enum*/

        System.Console.WriteLine("Orbital period for Mars = " + (int)PlanetPeriods.Mars + " days");

        /*	2.37.3.	Assign int value to the first element in an enum*/
        System.Console.WriteLine("Position of Earth = " + (int)Planets.Earth);
        System.Console.WriteLine("Planets.Earth = " + Planets.Earth);
    }
}
 