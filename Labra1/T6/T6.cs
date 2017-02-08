using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal litra = 7.02M, bensa = 1.595M, matka, kulutus, kustannus;
            Console.Write("Anna matka > ");

            matka = int.Parse(Console.ReadLine());
            
           
            kulutus = matka / 100 * litra;
            kustannus = bensa * kulutus;

            Console.Write("Bensaa kuluu {0:F2}", kulutus);
            Console.Write(" litraa, kustannus {0:F2}", kustannus);
            Console.WriteLine(" euroa");
            
        }
    }
}
