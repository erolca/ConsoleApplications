using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Lutfen Sayi Giriniz: ");

                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi + "girdiniz.");

            }
            catch (Exception ex) when(ex.Source== "mscorlib")
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
