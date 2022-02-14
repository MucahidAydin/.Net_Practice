using System;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler =new string[5];

            string[] hayvan ={"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi =new int[5];

            renkler[0]="mavi";
            dizi[3]=10;

            Console.WriteLine(hayvan[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("lütfen dizinin eleman sayisini giriniz: ");

            int diziUzunlugu =int.Parse(Console.ReadLine());
            int[] sayiDizisi =new int[diziUzunlugu];
            
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lütfen {0}. sayıyı giriniz : ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+=sayi;
            }

            Console.WriteLine("ortalama : "+(float)toplam/diziUzunlugu );
            Console.ReadKey();
        }
    }
}