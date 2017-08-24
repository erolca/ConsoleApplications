using System;

class MainClass
{

    public static void Main()
    {
        const int rows = 8;
        const int columns = 8;
        string[,] stringArray = new string[rows, columns];

        stringArray[0, 0] = "R";
        stringArray[1, 0] = "P";
        stringArray[2, 3] = "K";
        stringArray[3, 5] = "B";
        stringArray[4, 4] = "A";
        stringArray[5, 3] = "E";

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.WriteLine("stringArray[" + row + ", " + column + "] = " +
                  stringArray[row, column]);
            }
        }
    }
}