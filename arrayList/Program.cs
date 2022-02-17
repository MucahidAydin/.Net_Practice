using System;
using System.Collections;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("mucahid");
            liste.Add(2);
            liste.Add(true);
            liste.Add('m');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
                Console.WriteLine(item);

            string[] renkler = { "sarı", "kırmızı", "mavi" };
            List<int> sayılar = new List<int>() { 1, 9, 55, 565, 564, 65, 654, 65456, 464, 564, 648, 65, 47, 6 };
            liste.AddRange(renkler);
            liste.AddRange(sayılar);


            foreach (var item in liste)
                Console.WriteLine(item);

            //sort
            ArrayList liste2 = new ArrayList() { 1, 7546, 3254, 2523, 5, 35, 3245, 23, 5, 4, 6, 53, 7, 5467, 23, 5, 24, 65, 7, 43, 5, 235, 3, 453, 52135324, 6, 4, 526, 54, 4352, 354, 43 };

            liste2.Sort();

            foreach (var item in liste2)
                Console.WriteLine(item);

            //Sort => Binary Search
            Console.WriteLine(liste2.BinarySearch(5467));

            //Reverse
            liste2.Reverse();
            foreach (var item in liste2)
                Console.WriteLine(item);

            //Clear
            liste.Clear();
            liste2.Clear();


            Console.ReadKey();
        }
    }
}