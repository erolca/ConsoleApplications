class MainClass
{

    public static void Main()
    {

        int myInt = 0;
        bool compatible = myInt is int;
        System.Console.WriteLine("myInt is int = " + compatible);

        compatible = myInt is long;
        System.Console.WriteLine("myInt is long = " + compatible);

        compatible = myInt is float;
        System.Console.WriteLine("myInt is float = " + compatible);

    }

}