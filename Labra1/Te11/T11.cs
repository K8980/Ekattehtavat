using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Te11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit = 0;

            Console.WriteLine("Anna rivien määrä: ");
            rivit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rivit; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
