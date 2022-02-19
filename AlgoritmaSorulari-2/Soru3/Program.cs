using System;
using System.Collections;

namespace Soru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz");
            string cumle = Console.ReadLine();

            cumle = cumle.ToLower();
            ArrayList liste = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == 'i' || cumle[i] == 'ı' || cumle[i] == 'u' || cumle[i] == 'ü' || cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'o' || cumle[i] == 'ö')
                {
                    liste.Add(cumle[i]);
                }
            }

            liste.Sort();
            Console.WriteLine("");
            Console.Write("=> ");
            foreach (var item in liste)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}