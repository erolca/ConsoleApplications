using System;

class MainClass
{
    public static void Main()
    {
        byte val1 = 200;
        byte val2 = 201;
        byte sum = (byte)(val1 + val2);   // no exception
        checked
        {
            byte sum2 = (byte)(val1 + val2);      // exception
        }
    }
}

/*System.OverflowException: 'Aritmetik işlem taşmayla sonuçlandı.'*/
