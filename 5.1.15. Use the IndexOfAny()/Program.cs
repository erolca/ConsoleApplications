using System;

class MainClass
{

    public static void Main()
    {
        string[] myStrings = { "To", "be", "or", "not", "to", "be" };
        string myString = String.Join(".", myStrings);

        char[] myChars = { 'b', 'e' };
        int index = myString.IndexOfAny(myChars);
        Console.WriteLine("'b' and 'e' occur at index " + index + " of myString");
        index = myString.LastIndexOfAny(myChars);
        Console.WriteLine("'b' and 'e' last occur at index " + index + " of myString");




        char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };
        String s = "The long and winding road...";
        Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                          s, s.IndexOfAny(chars) + 1);

        char[]  charx ={ 'D','a'};
        s = "Kara Deniz...";
        Console.WriteLine(" {0}", s.IndexOfAny(charx) + 1);


    }

}