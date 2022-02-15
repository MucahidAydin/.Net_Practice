using System;

namespace Soru2
{
	internal class Program
	{
		static void Main(string[] args){
			
			Console.Write(" n sayısını giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.Write(" m sayısını giriniz: ");
            int sayi2=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
			{
				Console.Write("{0}. sayıyı giriniz : ",(i+1));
				int sayi3=Convert.ToInt32(Console.ReadLine());

				if (sayi2%sayi3==0)
				{
					Console.WriteLine("{0} m sayısını tam bölüyor.",sayi2);
				}
				else
				{
					Console.WriteLine("{0} m sayısını tam bölmüyor.",sayi2);
				}
			}

            Console.ReadKey();
		}
	}
}