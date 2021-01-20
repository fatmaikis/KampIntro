using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java" };

            for(int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");




            // foreach dizilerin elemanlarını tek tek dolaşır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
