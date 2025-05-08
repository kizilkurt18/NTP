using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ogrenciler = new Hashtable();
            ogrenciler.Add("Eyyub", 7);
            ogrenciler.Add("Mehmet", 14);
            ogrenciler.Add("Ahmet", 16);
            ogrenciler.Add("Ali",10);
            //eklemek için üsttekileri kullanıyoruz..

            //silmek için bunları;
            ogrenciler.Remove("Eyyub");
            ogrenciler.Remove("14");

            //güncellemek için bunu;
            ogrenciler[16] = "Erdal";
            ogrenciler["Ali"] = 18;

            /*
            foreach (var anahtar in ogrenciler.Keys)
            {
                Console.WriteLine(anahtar);
            }
            foreach (var deger in ogrenciler.Values)
            {
                Console.WriteLine(deger);
            }

            EKRANA TEKER TEKER YAZDIRMAK İÇİN BUNLARI KULLANIYORUZ..
            */
            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + "-" + eleman.Value);
            }


        }
    }
}
