using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elması";

            


            //string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 100;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün adı:" + urun.Adi);
                Console.WriteLine("Ürün fiyatı:" + urun.Fiyati);
                Console.WriteLine("Ürünün açıklaması:" + urun.Aciklama);
                Console.WriteLine("ürünün stok adedi:" + urun.StokAdedi);
                Console.WriteLine("--------------------------");          
            }

            Console.WriteLine("--------metotlar------------");


            //instance örneği
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 8);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 80);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12, 5);






        }
    }
}
