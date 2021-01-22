using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Mehmet";
            musteri1.MusteriSoyadi = "Kayalı";
            musteri1.MusteriYasi = 25;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Selinay";
            musteri2.MusteriSoyadi = "Yıldız";
            musteri2.MusteriYasi = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Gizem";
            musteri3.MusteriSoyadi = "Koç";
            musteri3.MusteriYasi = 32;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAdi = "Serhat";
            musteri4.MusteriSoyadi = "Akça";
            musteri4.MusteriYasi = 37;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Sil(musteri1);
        
            musteriManager.Ekle(musteri2);

            Musteri[] musteriList = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            musteriManager.Listele(musteriList);
        }
            
        
    }
}
