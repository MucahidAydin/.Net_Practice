using System;

namespace Soru4
{
	internal class Program
	{
		static void Main(string[] args)
		{

		    Console.Write("Bir cümle yazınız : ");
		    string cumle=Console.ReadLine();

		    string[] dizi = cumle.Split(" ");        
		    Console.WriteLine("Cümle sayısı : "+dizi.Length);
		    Console.WriteLine("Kelime sayısı : "+string.Join("",dizi).Length);          

		    Console.ReadKey();
		}
	}
}
