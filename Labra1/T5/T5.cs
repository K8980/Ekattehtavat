using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunti, tunti, minuutti;

            Console.Write("Anna sekunnit > ");

            sekunti = int.Parse(Console.ReadLine());

            tunti = sekunti / 3600;
            sekunti = sekunti % 3600;
            minuutti = sekunti / 60;
            sekunti = sekunti % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tunti + " tuntia, " + minuutti + " minuuttia ja " + sekunti + " sekuntia. " );
           
        }
    }
}
