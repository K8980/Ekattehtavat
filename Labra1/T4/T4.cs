using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;

            Console.Write("Anna ikä > ");

            ika = int.Parse(Console.ReadLine());


            if (ika < 18 & ika > -1)
            {
                Console.WriteLine("Alaikäinen ");
            }
                else if (ika < 66 & ika > 17)
            {
                Console.WriteLine("Aikuinen ");
            }
                else
                { 
                Console.WriteLine("Seniori ");
            }
        }
    }
}
