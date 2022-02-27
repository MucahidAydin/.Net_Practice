using System;

namespace ConstructorMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kurucu Metotlar
            Console.WriteLine("******** Çalışan1 ********");
            Calisan calisan1 = new Calisan("mücahid", "aydin", 00101111, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("******** Çalışan2 ********");
            calisan1.Ad = "deniz";
            calisan1.Soyad = "arda";
            calisan1.No = 10101111;
            calisan1.Departman = "Satın Alma";
            calisan1.CalisanBilgileri();

            Console.WriteLine("******** Çalışan3 ********");
            Calisan calisan2 = new Calisan("mücahid", "aydin");
            calisan2.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        //Metot Overloading
        public Calisan() { }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}