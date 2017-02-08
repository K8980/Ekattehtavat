using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            float luku1, luku2, luku3;
            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 & luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on " + luku1);
            }
            else if (luku2 > luku1 & luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on " + luku2);
            }
            else if (luku3 > luku2 & luku3 > luku1)
            {
                Console.WriteLine("Suurin luku on " + luku3);
            }
            else
            {
                Console.WriteLine(" Virhe ilmoitus: Kaikki luvut ovat yhtäsuuria tai on 2 suurinta lukua.");
            }
        }
    }
}