using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("mücahid", "aydin", 47, 3);
            ogrenci.OgrenciBilgileri();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileri();

            Ogrenci ogrenci2 = new Ogrenci("deniz", "arda", 256, 1);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileri();


            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az bir olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci() { }
        public Ogrenci(string isim1, string soyad1, int ogrenciNo1, int sinif1)
        {
            Isim = isim1;
            Soyad = soyad1;
            OgrenciNo = ogrenciNo1;
            Sinif = sinif1;
        }
        public void OgrenciBilgileri()
        {
            Console.WriteLine("********* Öğrenci Bilgileri ********");
            Console.WriteLine("Öğrenci Adı    : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyad);
            Console.WriteLine("Öğrenci No     : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif += 1;
        }
        public void SinifDusur()
        {
            this.Sinif -= 1;
        }
    }
}