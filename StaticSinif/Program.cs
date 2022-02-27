using System;

namespace StaticSinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : {0}", calisan.CalisanSayisi);

            calisan calisan1 = new calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan sayısı : {0}", calisan.CalisanSayisi);

            calisan calisan2 = new calisan("Mücahid", "Aydin", "IK");
            calisan calisan3 = new calisan("Zikriye", "Ürkmez", "IK");
            //calisan3.Isim1="zikriye";            

            Console.WriteLine("Çalışan sayısı : {0}", calisan.CalisanSayisi);

            Console.WriteLine("Toplama İşlemi : {0}", Islemler.Topla(4000, 240));
            Console.WriteLine("Çıkarma İşlemi : {0}", Islemler.Cikar(420, 20));
            Console.WriteLine("Toplama İşlemi : {0}", Islemler.Topla(400, 240));


            Console.ReadKey();
        }
    }
    class calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }
        //public string Isim1 { get => Isim; set => Isim = value; }

        private string Isim;
        private string Soyad;
        private string Departman;

        //class'a ilk erişimde çalışır.
        static calisan()
        {
            calisanSayisi = 0;
        }
        public calisan(string isim, string soyad, string departman)
        {
            this.Isim = isim;
            this.Soyad = soyad;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
        static Islemler()
        {
            Console.WriteLine("class'a ilk erişimde çalışır.");
        }
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}