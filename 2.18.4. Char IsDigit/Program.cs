using System;

class MainClass
{
    public static void Main()
    {

        /*2.18.4.	Char: IsDigit*/
        string str = "This is a test. $23";
        int i;

        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsDigit(str[i]))
                Console.Write(" digit");

            Console.WriteLine();
        }


        /*2.18.5.	Char: IsLetter*/
        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsLetter(str[i]))
                Console.Write(" letter");

            Console.WriteLine();
        }


        /*	2.18.6.	Char: IsLower/IsUpper*/
        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsLower(str[i]))
                Console.Write(" lowercase");
            if (Char.IsUpper(str[i]))
                Console.Write(" uppercase");

            Console.WriteLine();
        }


        /*2.18.7.	Char: IsSymbol*/
        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsSymbol(str[i]))
                Console.Write(" symbol");

            Console.WriteLine();
        }



        /*2.18.8.	Char: IsSeparator*/
        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsSeparator(str[i]))
                Console.Write(" separator");

            Console.WriteLine();
        }

        /*2.18.9.	Char: IsWhiteSpace*/

        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsWhiteSpace(str[i]))
                Console.Write(" whitespace");

            Console.WriteLine();
        }

        /*2.18.10.	Char: IsPunctuation*/
        for (i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " is");
            if (Char.IsPunctuation(str[i]))
                Console.Write(" punctuation");

            Console.WriteLine();
        }

        /*2.18.11.	Convert character to upper case*/

        Console.WriteLine("Original: " + str);

        // .    
        string newstr = "";
        for ( i = 0; i < str.Length; i++)
            newstr += Char.ToUpper(str[i]);

        Console.WriteLine("Uppercased: " + newstr);


       /* 2.18.12.Use a char to control the switch.*/
        char ch;

        for (ch = 'A'; ch <= 'E'; ch++)
            switch (ch)
            {
                case 'A':
                    Console.WriteLine("ch is A");
                    break;
                case 'B':
                    Console.WriteLine("ch is B");
                    break;
                case 'C':
                    Console.WriteLine("ch is C");
                    break;
                case 'D':
                    Console.WriteLine("ch is D");
                    break;
                case 'E':
                    Console.WriteLine("ch is E");
                    break;
            }

        /*2.18.15.	Char type Functionality*/
        char myChar = 'a';
        Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
        Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
        Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
        Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
        Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));

        /*2.18.17.	Displaying Each Character's ASCII Value in Descending Order*/
        char current;
        int asciiValue;

        current = 'z';
        do
        {
            asciiValue = current;
            System.Console.Write("{0}={1}\t", current, asciiValue);
            current--;

        }
        while (current >= 'a');


        System.Console.WriteLine();
        System.Console.Write('\u003A');
        System.Console.WriteLine('\u0029');

    }


}

 
 
 
 
 
 
 
 