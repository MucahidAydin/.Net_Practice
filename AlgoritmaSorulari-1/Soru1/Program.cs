using System;

namespace Soru1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Dizi boyutunu giriniz : ");
			int sayi=Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < sayi; i++)
			{
				Console.Write("{0}. sayıyı giriniz : ",(i+1));
				int sayi2=Convert.ToInt32(Console.ReadLine());
				if (sayi2%2==0)
				{
					Console.WriteLine("{0} çift",sayi2);
				}
				else
				{
					Console.WriteLine("{0} tek",sayi2);
				}

			}
			

            Console.ReadKey();
		}
	}
}