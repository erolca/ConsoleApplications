using System;

class MainClass
{
    public static void Main()
    {
        int num;
        int i;
        int factor;
        bool isprime;


        for (num = 2; num < 20; num++)
        {
            isprime = true;
            factor = 0;

            // see if num is evenly divisible 
            for (i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                {
                    // num is evenly divisible -- not prime 
                    isprime = false;
                    factor = i;
                    break;
                }
            }

            if (isprime)
                Console.WriteLine(num + " is prime.");
            else
                Console.WriteLine("Largest factor of " + num +
                                  " is " + factor);
        }

    }
}