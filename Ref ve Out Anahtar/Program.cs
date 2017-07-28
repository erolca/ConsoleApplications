using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Makale 
 * 
 * http://www.csharpnedir.com/articles/read/?id=145
 * 
 */


namespace Ref_ve_Out_Anahtar
{
    class C
    {
        public int deger;
        public C(int x)
        {
            deger = x;
        }
    }

    class Decompose
    {

        public int parts(double n, out double frac)
        {
            int whole;

            whole = (int)n;
            frac = n - whole; // pass fractional part back through frac 
            return whole; // return integer portion 
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            C x = new C(10);
            C y = new C(20);

            Degistir(x, y);

            Console.WriteLine("X = " + x.deger.ToString());
            Console.WriteLine("Y = " + y.deger.ToString());

            Decompose ob = new Decompose();
            int i;
            double f;

            i = ob.parts(10.125, out f);

            Console.WriteLine("Integer portion is " + i);
            Console.WriteLine("Fractional part is " + f);

        }


        static void Degistir(C x, C y)
        {
            int temp = x.deger;
            x.deger = y.deger;
            y.deger = temp;
        }

    }
}
