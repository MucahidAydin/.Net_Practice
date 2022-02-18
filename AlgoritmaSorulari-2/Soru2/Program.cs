using System;
using System.Collections;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            ArrayList veri = new ArrayList();

            while (true)
            {
                try
                {
                    bool kontrol = false;
                    Console.WriteLine("Lütfen bir sayı giriniz ");
                    uint sayi = uint.Parse(Console.ReadLine());
                    veri.Add(sayi);
                    sayac++;
                    if (sayac == 20)
                        break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }

            veri.Sort();
            uint[] dizi = new uint[veri.Count];
            veri.CopyTo(dizi, 0);

            float EnKücükOrtalama = ((float)(dizi[0] + dizi[1] + dizi[2]) / 3);
            float EnBüyükOrtalama = ((float)(dizi[dizi.Length - 1] + dizi[dizi.Length - 2] + dizi[dizi.Length - 3]) / 3);

            Console.WriteLine("Enküçük 3 sayını ortalaması : " + EnKücükOrtalama);
            Console.WriteLine("Enbüyük 3 sayını ortalaması : " + EnBüyükOrtalama);
            Console.WriteLine("Ortalama toplamı : " + (EnKücükOrtalama + EnBüyükOrtalama).ToString("0.##"));

            Console.ReadKey();
        }
    }
}