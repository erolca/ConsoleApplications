using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CokBicimlilik_MetotEzme
{
    class Program
    {
        static void Main(string[] args)
        {
            int diziBoyutu = 10;

            Ucgen uc1 = new Ucgen(20,30);
            uc1.Yazdir();

            //Sekil sekil1 = uc1;
            //sekil1.Yazdir();

            Kare k1 = new Kare(39);
            k1.x = 15;
            k1.y = 20;
            k1.Yazdir();


        }
    }
}
