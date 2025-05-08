using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList ogrenciler = new SortedList();
            ogrenciler.Add(368, "Ahmet");//Ekleme
            ogrenciler.Add(500, "Eyupcan");

            ogrenciler.Remove(368);//Silme

            ogrenciler[500] = "Eyyub";//Güncelle

            foreach (DictionaryEntry eleman in ogrenciler)
            {
                Console.WriteLine(eleman.Key + " - " + eleman.Value);
            }
            
        }
    }
}
