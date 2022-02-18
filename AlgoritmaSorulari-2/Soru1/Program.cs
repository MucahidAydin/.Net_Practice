using System;
using System.Collections;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayac = 0;
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            while (true)
            {
                try
                {
                    bool kontrol = false;
                    Console.WriteLine("Lütfen bir sayı giriniz ");
                    uint sayi = uint.Parse(Console.ReadLine());

                    //Console.WriteLine(sayi);
                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            kontrol = true;
                            break;
                        }
                        else
                            kontrol = false;
                    }
                    if (kontrol == true)
                        asalOlmayan.Add(sayi);
                    else
                        asal.Add(sayi);

                    sayac++;
                    if (sayac == 5)
                        break;
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş.");
                }
            }
            float asalOrtalama = 0;          //ToString("0.##")
            double asalOlmayanOrtalama = 0;  //ToString("0.####")

            asal.Sort();
            asalOlmayan.Sort();

            Console.Write("asal : ");
            foreach (var item in asal)
            {
                Console.Write(item + " ");
                asalOrtalama += Convert.ToInt32(item);
            }
            Console.Write("Eleman sayısı : " + asal.Count);
            Console.Write(" asalOrtalama : " + (asalOrtalama / asal.Count).ToString("0.##"));

            Console.WriteLine();
            Console.Write("asalOlmayan : ");
            foreach (var item2 in asalOlmayan)
            {
                Console.Write(item2 + " ");
                asalOlmayanOrtalama += Convert.ToInt32(item2);
            }
            Console.Write("Eleman sayısı : " + asalOlmayan.Count);
            Console.Write(" asalOlmayanOrtalama : " + (asalOlmayanOrtalama / asalOlmayan.Count));


            Console.ReadKey();
        }
    }
}