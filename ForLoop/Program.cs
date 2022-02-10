using System;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac =int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            int tekToplam = 0;
            int ciftToplam = 0;
            
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2==1)
                    tekToplam+=i;
                else
                    ciftToplam+=i;                
            }

            Console.Write("Tek Toplam : "+tekToplam);
            Console.WriteLine("");
            Console.Write("Çift Toplam : "+ciftToplam);
            Console.WriteLine("");

          for (int i = 1; i < 10; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine(i);
            }            
            for (int i = 1; i < 10; i++)
            {
                if (i == 7)
                    continue;
                Console.WriteLine(i);
            }

            
            Console.ReadKey();
        }
    }
}