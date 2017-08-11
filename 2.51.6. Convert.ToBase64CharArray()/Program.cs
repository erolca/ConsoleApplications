using System;

class Sample
{
    public static void Main()
    {
        byte[] byteArray1 = new byte[256];
        byte[] byteArray2 = new byte[256];
        char[] charArray = new char[352];
        int charArrayLength;
        for (int x = 0; x < byteArray1.Length; x++)
        {
            byteArray1[x] = (byte)x;
            Console.Write("{0:X2} ", byteArray1[x]);
        }
        charArrayLength = Convert.ToBase64CharArray(byteArray1, 0, byteArray1.Length, charArray, 0, Base64FormattingOptions.InsertLineBreaks);
        Console.Write(charArrayLength);

        Console.WriteLine(new String(charArray));

        byteArray2 = Convert.FromBase64CharArray(charArray, 0, charArrayLength);
    }
}