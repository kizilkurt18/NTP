using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen_alan_cevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            dikdortgen d = new dikdortgen(3, 4);
            Console.WriteLine("dikdortgenin alanı = {0}",d.alanHesaplama());
            Console.WriteLine("dikdortgenin çevresi = {0}", d.cevreHesaplama());
            Console.ReadLine();

        }
    }
}
