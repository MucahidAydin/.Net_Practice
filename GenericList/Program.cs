using System;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);

            List<string> renkler = new List<string>();
            renkler.Add("Mavi");
            renkler.Add("Sarı");
            renkler.Add("Yeşil");
            renkler.Add("Kırmızı");
            renkler.Add("Turuncu");

            //Count
            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);


            foreach (var sayi in sayilar)
                Console.WriteLine(sayi);
            foreach (var renk in renkler)
                Console.WriteLine(renk);

            //List.ForEach
            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            //Remove
            sayilar.Remove(4);
            renkler.Remove("Turuncu");

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkler.ForEach(renk => Console.WriteLine(renk));

            //Remove index
            sayilar.RemoveAt(3);

            //Liste içerisinde arama
            if (sayilar.Contains(2))
                Console.WriteLine("2 Liste içerisinde bulundu.");

            //Eleman ile index'e erişme
            Console.WriteLine(renkler.BinarySearch("Yeşil"));

            //Diziyi list'e çevirme
            string[] hayvalar = { "kedi", "köpek", "kuş" };
            List<string> HayvanListesi = new List<string>(hayvalar);

            //Liste temizleme
            renkler.Clear();

            //Liste içerisinde nesne tutma
            List<Kullanicilar> Kullanicilar = new List<Kullanicilar>();
            Kullanicilar k1 = new Kullanicilar();

            k1.Isim1 = "Mücahid";
            k1.Soyisim1 = "Aydin";
            k1.Yas1 = 25;

            Kullanicilar k2 = new Kullanicilar();

            k2.Isim1 = "Ayşe";
            k2.Soyisim1 = "Yılmaz";
            k2.Yas1 = 26;

            Kullanicilar.Add(k1);
            Kullanicilar.Add(k2);


            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim1 = "Ayşe",
                Soyisim1 = "Kul",
                Yas1 = 22
            });

            foreach (var item in Kullanicilar)
            {
                Console.WriteLine(item.Isim1);
                Console.WriteLine(item.Soyisim1);
                Console.WriteLine(item.Yas1);
            }
            foreach (var item in yeniListe)
            {
                Console.WriteLine(item.Isim1);
                Console.WriteLine(item.Soyisim1);
                Console.WriteLine(item.Yas1);
            }

            Console.ReadKey();
        }
    }
    public class Kullanicilar
    {
        private string Isim;
        private string Soyisim;
        private int Yas;

        public string Isim1 { get => Isim; set => Isim = value; }
        public string Soyisim1 { get => Soyisim; set => Soyisim = value; }
        public int Yas1 { get => Yas; set => Yas = value; }
    }
}