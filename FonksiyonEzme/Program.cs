using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonksiyonEzme
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil1 = new Kare(20);
            Sekil sekil2 = new Ucgen(20,30); // new Sekil();
            sekil1.Yazdir();
            sekil2.Yazdir();

            /**/
            Ucgen uc1 = new Ucgen(10,20);
            uc1.Yazdir();
            Sekil sekil3 = uc1;
            sekil3.Yazdir();
        }
    }
}
 