using System;

class MainClass
{

    static int SumVals(params int[] vals)
    {
        int sum = 0;
        foreach (int val in vals)
        {
            sum += val;
        }
        return sum;
    }
    //dikkat ederseniz params en sonda ve diğer parametrelerde tek değişkene sahip.
    static int Notlar(string adi, string soyadi, int yasi, params int[] say)
    {
        int cResult = 0;
        // kodlar
        return cResult;
    }


    public static void Main()
    {

        //params
        int sums = SumVals(1, 5, 2, 9, 8);
        Console.WriteLine("Summed Values = {0}", sums);

        Write("A", "B");
        Write("A", "B", "C", 12, 14.2);
        object[] arr = new object[4];
        arr[0] = "A";
        arr[1] = "B";
        arr[2] = "C";
        arr[3] = 42;
        Write("AAA", arr);
    }







    public static void Write(string label, object arg)
    {
        WriteString(label);
        WriteString(arg.ToString());
    }
    // version with an array of object parameters
    public static void Write(string label, params object[] args)
    {
        WriteString(label);
        foreach (object o in args)
        {
            WriteString(o.ToString());
        }
    }
    public static void WriteString(string str)
    {
        // writes string to the port here
        Console.WriteLine("Port debug: {0}", str);
    }

}