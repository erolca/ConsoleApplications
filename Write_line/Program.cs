using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Write_line
{
    class Program
    {
        static void Main(string[] args)
        {


            /*14.3.1.	Console I/O*/

            /*************************************************************************************************
             * 14.3.2.	WriteLine
             * This is text 1.
             * This is text 2.
             * This is text 3.
            *************************************************************************************************/
            System.Console.WriteLine("14.3.2.	WriteLine");
            System.Console.WriteLine("");

            System.Console.WriteLine("This is text 1.");
            System.Console.WriteLine("This is text 2.");
            System.Console.WriteLine("This is text 3.");
            System.Console.WriteLine("");

            /*************************************************************************************************
             *14.3.3.	Write without new line
             * This is text 1.This is text 2.This is text 3.
             *************************************************************************************************/

            System.Console.WriteLine("14.3.3    Write without new line");
            System.Console.WriteLine("");

            System.Console.Write("This is text 1.");
            System.Console.Write("This is text 2.");
            System.Console.Write("This is text 3.\n");
            System.Console.WriteLine("");



            /*************************************************************************************************
             *14.3.4.	Substituting Values
             * 3 and 6.
             *************************************************************************************************/
            System.Console.WriteLine("14.3.4.	Substituting Values");
            System.Console.WriteLine("");

            Console.WriteLine(" {0} and {1}.", 3, 6);

            System.Console.WriteLine("");




            /*************************************************************************************************
             *14.3.5.	Substituting Values twice
             * 6, 3 and 6.
             *************************************************************************************************/
            System.Console.WriteLine("14.3.5.	Substituting Values twice");
            System.Console.WriteLine("");

            Console.WriteLine("{1}, {0} and {1}.", 3, 6);

            System.Console.WriteLine("");

            /*************************************************************************************************
             *14.3.6.	Write to Console.Out and Console.Error
             * This will generate an exception.
             * Attempted to divide by zero.
             *************************************************************************************************/

            System.Console.WriteLine("14.3.6.	Write to Console.Out and Console.Error");
            int a = 10, b = 0;
            int result;

            Console.Out.WriteLine("This will generate an exception.");
            try
            {
                result = a / b; // generate an exception 
            }
            catch (DivideByZeroException exc)
            {
                Console.Error.WriteLine(exc.Message);
            }


            /*************************************************************************************************
             * 14.3.7.	Output an int to console
             * Value is: 3
             *************************************************************************************************/
            System.Console.WriteLine("14.3.7.	Output an int to console");
            System.Console.WriteLine("");

            Console.WriteLine("Value is: {0}", 3);

            System.Console.WriteLine("");

            /*************************************************************************************************
             * 14.3.8.	Concatenate string in Console.WriteLine
             * Hello World
             *************************************************************************************************/
            System.Console.WriteLine("14.3.8.	Concatenate string in Console.WriteLine");
            System.Console.WriteLine("");

            Console.WriteLine("Hello " + "World");

            System.Console.WriteLine("");

            /*************************************************************************************************
             * 14.3.9.	Format the same argument three different ways
             * 10.12  10.123  1.012345e+001
             *************************************************************************************************/

            System.Console.WriteLine("14.3.9.	Format the same argument three different ways");
            System.Console.WriteLine("");

            Console.WriteLine("{0:F2}  {0:F3}  {0:e}", 10.12345);

            System.Console.WriteLine("");

            /*************************************************************************************************
             * 14.3.10.	Display arguments in non-sequential order
             * 3 1 2
             *************************************************************************************************/
            System.Console.WriteLine("14.3.10.	Display arguments in non-sequential order");
            System.Console.WriteLine("");

            Console.WriteLine("{2:d} {0:d} {1:d}", 1, 2, 3);

            System.Console.WriteLine("");

            /*************************************************************************************************
            *14.3.11.	Variable index
            * Jim is 25 years old.
            **************************************************************************************************/
            System.Console.WriteLine("14.3.11.	Variable index");
            System.Console.WriteLine("");
            int age = 25;
            string name = "Jim";
            Console.WriteLine(String.Format("{0} is {1} years old.", name, age));
            System.Console.WriteLine("");

            /*************************************************************************************************
             * 14.3.12.	Variable index: reference a variable more than once
             * Hello there. I said Hello! Hello???
             **************************************************************************************************/
            System.Console.WriteLine("14.3.12.	Variable index: reference a variable more than once");
            System.Console.WriteLine("");

            name = "Hello";
            Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
            System.Console.WriteLine("");

            /*
             *14.3.13.	Escape Characters: \\
             * Here comes a slash \
             */
            System.Console.WriteLine("14.3.13.	Escape Characters: \\");
            System.Console.WriteLine("");

            Console.WriteLine("Here comes a slash \\");

            System.Console.WriteLine("");

            /*
             * 14.3.14.	Adds a total of 4 blank lines (then beep again!)
             *
             */

            System.Console.WriteLine("14.3.14.	Adds a total of 4 blank lines (then beep again!)");
            System.Console.WriteLine("");

            Console.WriteLine("All finished.\n\n\n\a");

            System.Console.WriteLine("");

            /*
             *14.3.15.	Displaying a Triangle Using a Verbatim String Literal
             * 
             */
            System.Console.WriteLine("14.3.15.	Displaying a Triangle Using a Verbatim String Literal");
            System.Console.WriteLine("");

            System.Console.WriteLine("");

            System.Console.Write(@"begin
             /\
            /  \
           /    \
          /      \
         /________\
 end");

            System.Console.WriteLine("");


            /*
             *14.3.16.	Use OpenStandardOutput method.
             */
            System.Console.WriteLine("14.3.16.	Use OpenStandardOutput method.");
            System.Console.WriteLine("");

         
            StreamWriter writer = new StreamWriter(args[1]);
            Console.SetOut(writer);
            Console.SetIn(new StreamReader("c:\\test.txt"));
            string line = "asdf";
            Console.WriteLine(line);

            writer.Close();
            StreamWriter standardOutput = new StreamWriter(Console.OpenStandardOutput());
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            Console.WriteLine("");

        }
    }
}
