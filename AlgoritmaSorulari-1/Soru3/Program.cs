using System;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n sayısını giriniz: ");
		    int sayi=Convert.ToInt32(Console.ReadLine());		   

            string[] dizi=new string[sayi];
		    for (int i = 0; i < sayi; i++)
			{
				Console.Write("{0}. kelimeyi giriniz : ",(i+1));
				string kelime = Console.ReadLine();
                dizi[i]= kelime;
			}
            for (int i = (sayi-1); i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
            
            Console.ReadKey();
        }
    }
}