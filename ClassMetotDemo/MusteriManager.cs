using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " adlı müşteri eklendi!");
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " adlı müşteri silindi!" );
        }

        public void Listele (Musteri[] musteriler)
        {
            int i = 1;
            foreach  (Musteri musteri in musteriler)
            {
                Console.WriteLine("-------" + i + "------");
                i = i + 1;
                Console.WriteLine("ID: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri Yaşı: " + musteri.MusteriYasi);

            }
        }
    }
}
