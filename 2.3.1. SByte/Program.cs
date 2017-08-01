using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        CultureInfo[] cultures = { CultureInfo.CreateSpecificCulture("en-US"),
                                 CultureInfo.CreateSpecificCulture("fr-FR"),
                                 CultureInfo.CreateSpecificCulture("es-ES") };
        sbyte positiveNumber = 1;
        sbyte negativeNumber = -5;
        string[] specifiers = { "G", "C", "D4", "E2", "F", "N", "P", "X2" };

        foreach (string specifier in specifiers)
        {
            foreach (CultureInfo culture in cultures)
                Console.WriteLine("{0,2} format using {1} culture: {2, 16} {3, 16}",
                                  specifier, culture.Name,
                                  positiveNumber.ToString(specifier, culture),
                                  negativeNumber.ToString(specifier, culture));
        }

        sbyte value = -123;

        Console.WriteLine(value.ToString());

        Console.WriteLine(value.ToString("G"));
        Console.WriteLine(value.ToString("C"));
        Console.WriteLine(value.ToString("D"));
        Console.WriteLine(value.ToString("F"));
        Console.WriteLine(value.ToString("N"));
        Console.WriteLine(value.ToString("X"));

    }
}