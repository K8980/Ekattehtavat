using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class karkausvuosi
    {
        static void Main(string[] args)
        {
            karkausvuosi uus = new karkausvuosi();
            uus.syote();
            uus.karkaus();
        }
        int vuosi;
        public void syote()
        {
            Console.Write("Anna vuosi > ");
            vuosi = int.Parse(Console.ReadLine());
        }
        public void karkaus()
        {
            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
            {
                Console.WriteLine("Vuosi on karkausvuosi. ");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi. ");
            }
            
        }
    }
}
