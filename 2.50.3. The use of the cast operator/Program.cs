class MainClass
{

    public static void Main()
    {
        short myShort = 17000;
        System.Console.WriteLine("myShort = " + myShort);

        int myInt = myShort;
        System.Console.WriteLine("myInt = " + myInt);

        myShort = (short)(myInt * 2);
        myInt = myShort;
        System.Console.WriteLine("myShort = " + myShort);
    }
}