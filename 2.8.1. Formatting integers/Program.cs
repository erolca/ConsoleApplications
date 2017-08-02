using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MainClass
{
    public static void Main()
    {


        int myInt = 12345;
        int myInt2 = 67890;
        System.Console.WriteLine("myInt = {0, 6}, myInt2 = {1, 5}", myInt, myInt2);
        System.Console.WriteLine("myInt using 10:d = {0, 10:d}", myInt);
        System.Console.WriteLine("myInt using 10:x = {0, 10:x2}", myInt);


        /*2.8.2.	int format: {0:C}, {0:D}, {0:E}, {0:F}, {0:G}, {0:N}, {0:P}, {0:X}*/
        int i = 123456;
        Console.WriteLine("{0:C}", i); // ?23,456.00
        Console.WriteLine("{0:D}", i); // 123456
        Console.WriteLine("{0:E}", i); // 1.234560E+005
        Console.WriteLine("{0:F}", i); // 123456.00
        Console.WriteLine("{0:G}", i); // 123456
        Console.WriteLine("{0:N}", i); // 123,456.00
        Console.WriteLine("{0:P}", i); // 12,345,600.00 %
        Console.WriteLine("{0:X}", i); // 1E240

        /**/

        int value = Int32.Parse("99953");
        Console.WriteLine("{0}", value);



        /*2.9.2.	Use TryParse from int
         * C#' ta bazı sınıfların TryParse motodu bulunmaktadır. 
         * Bu sınıflara örnek olarak double, int, byte, bool gibi sınıfları gösterebiliriz. 
         * Metodun kullanım amacı gönderilen değerin ilgili türe dönüşüp dönüşemeyeğini belirlemektir. 
         * TryParse metodu geriye bool tipinde değer döndürmektedir.
         * Eğer parametre olarak gönderilen değer dönüştürülmek istenilen değere dönüşürse 
         * out parametresi ile gönderilen parametreye sonucu aktarmaktadır.*/


        Console.WriteLine("Please enter an integer and press Enter");
        int numberEntered;
        string strRead = "25";
        while (!int.TryParse(/*Console.ReadLine()*//*string*/ strRead, out numberEntered))
        {
            Console.WriteLine("Please try again");
        }
        Console.WriteLine("You entered " + numberEntered.ToString());



        /*	2.10.1.	Use ToString() to format integers*/
        int x = 21;

        string str = x.ToString("X");       // 15
        Console.WriteLine(str);

        str = x.ToString("D12");            // 21
        Console.WriteLine(str);


        /*2.11.1.Numeric Formatting: Hexadecimal({ 0:X}, { 0:x8})*/
        Console.WriteLine("{0:X}", 255);    //FF
        Console.WriteLine("{0:x8}", 1456);  //000005b0


        // Display the value 42 using a hexadecimal literal.
        System.Console.WriteLine(0x002A);
        // Displays "0x2A"
        System.Console.WriteLine("0x{0:X}", 42);

        long MyLong = 10051234;
        object MyObject = MyLong;
        long MyLong2 = (long)MyObject;

    }

}
 
 