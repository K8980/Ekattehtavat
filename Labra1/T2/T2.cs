﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

            Console.Write("Anna pistemäärä > ");

            luku = int.Parse(Console.ReadLine());

            if (luku == 0 || luku == 1 )
            {
                Console.WriteLine("Koulunumero on 0 ");
            }
            if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Koulunumero on 1 ");
            }
            if (luku == 4 || luku == 5)
            {
                Console.WriteLine("Koulunumero on 2 ");
            }
            if (luku == 6 || luku == 7)
            {
                Console.WriteLine("Koulunumero on 3 ");
            }
            if (luku == 8 || luku == 9)
            {
                Console.WriteLine("Koulunumero on 4 ");
            }
            if (luku == 10 || luku == 11 || luku == 12)
            {
                Console.WriteLine("Koulunumero on 5 ");
            }
            if (luku > 12 || luku < 0 )
            {
                Console.WriteLine("Virheellinen arvosana ");
            }

        }
    }
}
