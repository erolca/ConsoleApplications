public class Swapper
{
    public void Swap(int x, int y)
    {
        System.Console.WriteLine("In Swap(): initial x = " + x + ", y = " + y);

        int temp = x;
        x = y;
        y = temp;

        System.Console.WriteLine("In Swap(): final   x = " + x + ", y = " + y);
    }
}


class MainClass
{

    public static void Main()
    {

        int x = 2;
        int y = 5;

        System.Console.WriteLine("In Main(): initial x = " + x + ", y = " + y);

        Swapper mySwapper = new Swapper();

        mySwapper.Swap(x, y);

        System.Console.WriteLine("In Main(): final   x = " + x + ", y = " + y);

    }

}