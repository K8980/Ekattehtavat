using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            float luku1, luku2, luku3, summa, keskiarvo;
            Console.Write("Anna 3 lukua > ");
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());
            summa = luku1 + luku2 + luku3;
            keskiarvo = summa / 3; 
            Console.Write("Lukujen summa on: ");
            Console.WriteLine(summa);
            Console.Write("Lukujen keskiarvo on: ");
            Console.WriteLine(keskiarvo);
        }
    }
}
