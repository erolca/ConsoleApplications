using System;

class Num
{

    public bool hasComFactor(int x, int y, out int least, out int greatest)
    {
        least = 1;
        greatest = 1;

        if (least != 1)
            return true;
        else
            return false;
    }
}

class MainClass
{
    public static void Main()
    {
        Num ob = new Num();
        int lcf, gcf;

        if (ob.hasComFactor(231, 105, out lcf, out gcf))
        {
            Console.WriteLine("Lcf of 231 and 105 is " + lcf);
            Console.WriteLine("Gcf of 231 and 105 is " + gcf);
        }
        else
            Console.WriteLine("No common factor for 35 and 49.");

        if (ob.hasComFactor(35, 51, out lcf, out gcf))
        {
            Console.WriteLine("Lcf of 35 and 51 " + lcf);
            Console.WriteLine("Gcf of 35 and 51 is " + gcf);
        }
        else
            Console.WriteLine("No common factor for 35 and 51.");

    }
}