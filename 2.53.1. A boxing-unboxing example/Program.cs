using System;
/*
 * int, float ve byte gibi stack'te tutulan bir değişkenin içeriğini Heap'ta tutulan object tipli
 * bir değişkene aktarılması işlemine Boxing
 *  adı verilmektedir.
 * 
 * Heap ta tutulan değişkenlerin içerikleri Stack te tutulan Value Type değişkenlere aktarılma
 * işlemine Unboxing adı verilmektedir.
 * */

class MainClass
{
    public static void Main()
    {
        int x;
        object obj;

        x = 10;
        obj = x; // box x into an object 

        int y = (int)obj; // unbox obj into an int 
        Console.WriteLine(y);
    }
}