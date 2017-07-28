using System;
using System.Collections.Generic;
using System.Linq;
using Counter;
using AnotherCounter;
using System.Text;
// Give Counter an alias called Ctr. 
using Ctr = Counter;


/*Demonstrate the :: qualifier. : Namespace « Language Basics « C# / CSharp Tutorial*/

namespace Counter
{
    class MyClass
    {
        private string str;
    }
}

namespace AnotherCounter
{
    class MyClass
    {

    }
}

/*****************************************************************************************/


/*The use of two namespaces : Namespace « Language Basics « C# / CSharp Tutorial*/
namespace DifferentCompany
{
    public class Car
    {
        public string make;
    }

}


namespace CompanyName
{
    public class Car
    {
        public string make;
    }

}
/*****************************************************************************************/

namespace Demonstrate_the_qualifier
{
    
    class MyClass
    {


      

            static void Main(string[] args)
        {
                Ctr::MyClass m = new Ctr::MyClass();
                Ctr.MyClass n = new Ctr.MyClass();


            /**/


                System.Console.WriteLine("Creating a CompanyName.Car object");
                CompanyName.Car myCar = new CompanyName.Car();
                myCar.make = "Toyota";
                System.Console.WriteLine("myCar.make = " + myCar.make);

                System.Console.WriteLine("Creating a DifferentCompany.Car object");
                DifferentCompany.Car myOtherCar = new DifferentCompany.Car();
                myOtherCar.make = "Porsche";
                System.Console.WriteLine("myOtherCar.make = " + myOtherCar.make);

               


            
        }
    }
}
