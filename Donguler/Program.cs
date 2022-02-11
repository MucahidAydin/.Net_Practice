using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir sayi  giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam+=sayac;
                sayac++;
            }            
            Console.WriteLine(toplam/sayi);
            
            char character='a';
            while (character <= 'z')
            {
                Console.WriteLine(character);
                character++;
            }

            string[] arabalar = {"BMV","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }



            Console.ReadKey();
        }
    }
}