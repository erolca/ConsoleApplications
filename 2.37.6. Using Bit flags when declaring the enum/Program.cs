using System;

[Flags]
enum Color : uint
{
    Red = 0x01, // Bit 0
    Blue = 0x02, // Bit 1
    Yellow = 0x04, // Bit 2
    Green = 0x08 // Bit 3
}

class MainClass
{
    static void Main()
    {
        Color ops = Color.Red | Color.Yellow | Color.Green;

        bool UseRed = false, UseBlue = false, UseYellow = false, UseGreen = false;

        UseRed = (ops & Color.Red) == Color.Red;
        UseBlue = (ops & Color.Blue) == Color.Blue;
        UseYellow = (ops & Color.Yellow) == Color.Yellow;
        UseGreen = (ops & Color.Green) == Color.Green;

        Console.WriteLine("Option settings:");
        Console.WriteLine("   Use Red    - {0}", UseRed);
        Console.WriteLine("   Use Blue   - {0}", UseBlue);
        Console.WriteLine("   Use Yellow - {0}", UseYellow);
        Console.WriteLine("   Use Green  - {0}", UseGreen);

        Console.Write("{0} - {1}", ops, (int)ops);
    }
}