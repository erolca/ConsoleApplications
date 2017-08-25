using System;

class MainClass
{
    public static void Main()
    {
        string[] input = {
                      "100 + 19",
                      "100 - 87"
                     };
        char[] seps = { ' ' };

        for (int i = 0; i < input.Length; i++)
        {
            string[] parts = input[i].Split(seps);
            Console.Write("Command: ");
            for (int j = 0; j < parts.Length; j++)
                Console.Write(parts[j] + " ");
        }
    }
}

/*
 * Command: 100 + 19 Command: 100 - 87
 */