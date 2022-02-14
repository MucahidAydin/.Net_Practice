using System;

namespace ArraySinifiMethodlari
{
	internal class Program
	{
		static void Main(string[] args)
		{
		  
	          int[] dizi={546,545,64,5454,5641,5154,51,8456,46,434,564,654,2,154,51,5,454,9145,498,6};

		  Console.WriteLine("*** sırasız dizi ***");
		  foreach (var sayi1 in dizi)
		    Console.WriteLine(sayi1);

		  Console.WriteLine("*** sıralı dizi ***");
		  Array.Sort(dizi);
		  foreach (var sayi1 in dizi)
		    Console.WriteLine(sayi1);

		  Console.WriteLine("*** Array clear ***");
		  Array.Clear(dizi,2,5);
		  foreach (var sayi1 in dizi)
		    Console.WriteLine(sayi1);

		  Console.WriteLine("*** Array reverse ***");
		  Array.Reverse(dizi);
		  foreach (var sayi1 in dizi)
		    Console.WriteLine(sayi1);

		 Console.WriteLine("*** Array Indexof ***");
		 Console.WriteLine(Array.IndexOf(dizi,545));


		 Console.WriteLine("*** Array resize ***");
		  Array.Resize<int>(ref dizi,25);
		  dizi[24]=545;

		  foreach (var sayi1 in dizi)
		    Console.WriteLine(sayi1);


		    Console.ReadKey();
		}
	}
}
