using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace format_numeric_data
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.55.1.	To format numeric data

           // Console. WriteLine("format string", arg0, arg1, ... , argN);

            //Format specifiers take this general form:
            //{argnum, width: fmt}
            /*
             * argnum specifies the number of the argument (starting from zero) to display.
             *  width specifies the minimum width of the field
             * fmt specifies the format
             * Both width and fmt are optional.
             *  {0} indicates arg0,
             * 
            */

            //  2.55.2.Numeric Formatting: Decimal({ 0:D}, { 0:D7})//

            Console.WriteLine("{0:D}", 123455);         //123455
            Console.WriteLine("{0:D7}", 543111);        //0543111

            //2.55.3.	Numeric Formatting: Fixed-Point ({0:F}, {0:F0}, {0:F5})

            Console.WriteLine("{0:F}", 12345.8977);         //12345.90
            Console.WriteLine("{0:F0}", 12314.8977);        //12315
            Console.WriteLine("{0:F5}", 5431123.8977);      //5431123.89770

            //2.55.4.	Numeric Formatting: General ({0:G}, {0:G7}, {0:G4})

            Console.WriteLine("{0:G}", 12345.8977);       //12345.8977
            Console.WriteLine("{0:G7}", 12345.8977);      //12345.9   
            Console.WriteLine("{0:G4}", 12345.8977);      //1.235E+04

            // 2.55.5.Numeric Formatting: Number({ 0:N}, { 0:N4})

            Console.WriteLine("{0:N}", 33345.8977);     //33,345.90
            Console.WriteLine("{0:N4}", 33345.8977);    //33,345.8977

            //2.55.6.	Numeric Formatting: Scientific (Exponential) ({0:E}, {0:E10}, {0:e4})

            Console.WriteLine("{0:E}", 33345.8977);     //3.334590E+004
            Console.WriteLine("{0:E10}", 33345.8977);   //3.3345897700E+004
            Console.WriteLine("{0:e4}", 33345.8977);    //3.3346e+004


            //2.55.7.	Custom Numeric Formatting: Decimal Point ({0:#####.000}, {0:##.000})

            Console.WriteLine("{0:#####.000}", 75928.3);        //75928.300
            Console.WriteLine("{0:##.000}", 1456.456456);       //1456.456

            //2.55.8.	Custom Numeric Formatting: Digit or Space Placeholder ({0:#####}, {0:###})

            Console.WriteLine("{0:#####}", 255);        //255
            Console.WriteLine("{0:#####}", 1456);       //1456
            Console.WriteLine("{0:###}", 32767);        //32767


            //2.55.9.	Custom Numeric Formatting: Digit or Zero Placeholder ({0:000})

            Console.WriteLine("{0:000}", 55);       //055
            Console.WriteLine("{0:000}", 1456);     //1456

            //2.55.10.	Custom Numeric Formatting: Escapes and Literals ({0:###\\#})

            Console.WriteLine("{0:###\\#}", 255);       //255#
            Console.WriteLine(@"{0:###\#}", 255);       //255#
            Console.WriteLine("{0:###'#0%;'}", 1456);   //1456#0%;

            //2.55.11.	Custom Numeric Formatting: Exponential Notation ({0:###.000E-00}, {0:#.0000000E+000})

            Console.WriteLine("{0:###.000E-00}", 3.1415533E+04);            //314.155E02
            Console.WriteLine("{0:#.0000000E+000}", 2.553939939E+101);      //2.5539399E+101


            // 2.55.12.Custom Numeric Formatting: Group Separator({ 0:##,###}, {0:##,000.000})

            Console.WriteLine("{0:##,###}", 2555634323);                 //2,555,634,323
            Console.WriteLine("{0:##,000.000}", 14563553.593993);       //14,563,553.594
            Console.WriteLine("{0:#,#.000}", 14563553.593993);          //14,563,553.594


            //2.55.13.	Custom Numeric Formatting: Number Prescaler ({0:000,,,.###})

            Console.WriteLine("{0:000,.##}", 158847);       //158.85
            Console.WriteLine("{0:000,,,.###}", 1593833);   //000.002

            //2.55.14.	Custom Numeric Formatting: Percent Notation ({0:##.000%})

            Console.WriteLine("{0:##.000%}", 0.89144);          //89.144%
            Console.WriteLine("{0:00%}", 0.01285);              //01%

            //2.55.15.	Custom Numeric Formatting: Section Separator ({0:###.00;0;(###.00)})
            Console.WriteLine("{0:###.00;0;(###.00)}", -456.55);        //457
            Console.WriteLine("{0:###.00;0;(###.00)}", 0);              //(.00)
            Console.WriteLine("{0:###.00;0;(###.00)}", 456.55);         //456.55


            Console.WriteLine("C format: {0:C}", 99989.987);        //C format: $99,989.99
            Console.WriteLine("D9 format: {0:D9}", 99999);          //D9 format: 000099999
            Console.WriteLine("E format: {0:E}", 99999.76543);      //E format: 9.999977E+004
            Console.WriteLine("F3 format: {0:F3}", 99999.9999);     //F3 format: 100000.000
            Console.WriteLine("N format: {0:N}", 99999);            //N format: 99,999.00
            Console.WriteLine("X format: {0:X}", 99999);            //X format: 1869F
            Console.WriteLine("x format: {0:x}", 99999);            //x format: 1869f

        }
    }
}
 