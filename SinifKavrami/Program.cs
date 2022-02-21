using System;

namespace SinifKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();

            calisan1.Ad = "mücahid";
            calisan1.Soyad = "aydin";
            calisan1.No = 00101111;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            calisan1.Ad = "deniz";
            calisan1.Soyad = "arda";
            calisan1.No = 10101111;
            calisan1.Departman = "Satın Alma";
            calisan1.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}