using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 02;
            musteri1.Adi = "kadir";
            musteri1.Soyadı = "kaya";
            musteri1.Sehir = "adıyaman";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 06;
            musteri2.Adi = "yusuf";
            musteri2.Soyadı = "demir";
            musteri2.Sehir = "istanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 35;
            musteri3.Adi = "ali";
            musteri3.Soyadı = "veli";
            musteri3.Sehir = "Trabzon";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);

                Console.WriteLine(musteri.Adi);

                Console.WriteLine(musteri.Soyadı);

                Console.WriteLine("-------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);


            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.MusteriEkle( 21 , "Murat" , "karaca" , "Adana");

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Sil(musteri3);



            

            

        }
    }
}
