using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FonksiyonEzme
{
    class Sekil
    {
        public int x;
        public int y;


		// temel sinifta virtual yazılıyor....
		// cok bicimlilik 
        public virtual void Yazdir()
        {

            Console.WriteLine("-----------SekilYazdir()-------------------");
            Console.WriteLine(x + "," + y);

        }

    }
}
