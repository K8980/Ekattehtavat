using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

            Console.Write("Anna luku > ");

            luku = int.Parse(Console.ReadLine());

            if (luku == 1 || luku == 2 || luku == 3)
            {
                Console.WriteLine("Annoit luvun " + luku);
            }
            else
	{
                Console.WriteLine("Joku muu luku ");
            }
           
        }
    }
}
