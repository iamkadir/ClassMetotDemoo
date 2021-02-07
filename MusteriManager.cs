using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(int Id, string Adi, string Soyadı , string Sehir)
        {
            Console.WriteLine(Id + " - " + Adi + " - " + Soyadı + " - " + Sehir );
        }

        public void Ekle (Musteri musteri)
        {
            Console.WriteLine( "Bilgiler: " +  musteri.Id + " - " +  musteri.Adi +" - " + musteri.Soyadı +" - " +musteri.Sehir);
        }
        
        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Silinecek Kişinin Id'si: 35 ");
        }

    }
}
