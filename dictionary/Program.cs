using System;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(5, "Mücahid Aydin");
            kullanicilar.Add(6, "Ayşe yılmaz");
            kullanicilar.Add(1, "Cüneyt Aydin");
            kullanicilar.Add(33, "Deniz Arda");

            //Elemanlara erişim
            Console.WriteLine(kullanicilar[5]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(5));
            Console.WriteLine(kullanicilar.ContainsValue("Mücahid"));
            Console.WriteLine(kullanicilar.ContainsValue("Mücahid Aydin"));

            //Remove
            kullanicilar.Remove(6);
            kullanicilar.Remove(33);
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

            foreach (var item in kullanicilar)
                Console.WriteLine(item.Key);

            //Keys
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);
            //Values
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);


            Console.ReadKey();
        }
    }
}