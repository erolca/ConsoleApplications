using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CompanyName
{
    namespace UserInterface  // nested namespace
    {
        public class MyClass
        {
            public void Test()
            {
                System.Console.WriteLine("UserInterface Test()");
            }
        }
    }
}


namespace CompanyName.DatabaseAccess  // nested namespace using dot
{
    public class MyClass
    {
        public void Test()
        {
            System.Console.WriteLine("DatabaseAccess Test()");
        }
    }
}

namespace namespace_hierarchies
{
    class Program
    {
        static void Main(string[] args)
        {


            CompanyName.UserInterface.MyClass myUI = new CompanyName.UserInterface.MyClass();
            CompanyName.DatabaseAccess.MyClass myDB = new CompanyName.DatabaseAccess.MyClass();

            CompanyName.DatabaseAccess.MyClass myMT = new CompanyName.DatabaseAccess.MyClass();

            myUI.Test();
            myDB.Test();
            myMT.Test();


        }
    }
}
