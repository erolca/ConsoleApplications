using System;
using WinForms = System.Windows.Forms;
using WebForms = System.Web.UI.WebControls;
using Ctr = Counter;
using CmpDb = Company.InternalClasses.Database.Table;
using dtbrl = Company.InternalClasses.DBInterface;

namespace Counter
{
    class MyClass
    {
    }
}

// Declare another class called CountDown, which  
// is in the global namespace.  
class MyClass
{
}

class GlobalAliasQualifierDemo
{
    public static void Main()
    {

        Ctr::MyClass m = new Ctr::MyClass();

        // Next, create CountDown object from global namespace. 
        global::MyClass m2 = new global::MyClass();


        //Using the alias keyword to refer to a nested namespace.
        CmpDb.Open("fred");
        dtbrl.Open();


        //Simple Aliases for namespace
        Console.WriteLine(typeof(WinForms.Button));
        Console.WriteLine(typeof(WebForms.Button));

        Console.WriteLine(typeof(global::MyClass));


        //Lifetime of a variable.
        int x;
     

        for (x = 0; x < 3; x++)
        {
             int  y = -1;
            Console.WriteLine("y is initialized each time block is entered.");
            Console.WriteLine("y is always -1: " + y);
            y = 100;
            Console.WriteLine("y is now: " + y);


        }
    }
}




namespace Company.InternalClasses
{
    public class DBInterface
    {
        public static void Open()
        {
            System.Console.WriteLine("Opening database");
        }
    }
    // Define a nested namespace within InternalClasses
    namespace Database
    {
        public class Table
        {
            public static void Open(string tblName)
            {
                System.Console.WriteLine("Opening table {0}", tblName);
            }
        }
    }
}