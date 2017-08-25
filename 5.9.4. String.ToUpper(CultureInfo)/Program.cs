using System;
using System.Globalization;

class Sample
{
    public static void Main()
    {
        String str1 = "this is a test";
        String str2, str3;

        str2 = str1.ToUpper(new CultureInfo("en-US", false));
        str3 = str1.ToUpper(new CultureInfo("tr-TR", false));

        Console.WriteLine(String.CompareOrdinal(str2, str3));
        foreach (ushort u in str1)
            Console.WriteLine("{0:x4} ", u);

        foreach (ushort u in str2)
            Console.WriteLine("{0:x4} ", u);

        foreach (ushort u in str3)
            Console.WriteLine("{0:x4} ", u);
    }

}