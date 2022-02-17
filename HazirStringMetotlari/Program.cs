using System;

namespace HazirStringMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "mücahid aydin";
            string b = "MÜCAHİD AYDİN";

            //Length
            Console.WriteLine(a.Length);

            Console.WriteLine(a.ToUpper());
            Console.WriteLine(b.ToLower());


            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(string.Compare(a, b, true));
            Console.WriteLine(string.Compare(a, b, false));

            //Contains
            Console.WriteLine(a.Contains(b));
            Console.WriteLine(a.EndsWith("in"));
            Console.WriteLine(a.StartsWith("m"));

            //IndexOf
            Console.WriteLine(a.IndexOf("id"));
            Console.WriteLine(a.LastIndexOf("aydin"));

            //Insert
            Console.WriteLine(a.Insert(0, "Merhaba "));

            //PadLeft, PadRight
            Console.WriteLine(a + b.PadLeft(13, '/'));
            Console.WriteLine(a + b.PadLeft(30, '/'));

            //Remove
            Console.WriteLine(a.Remove(7));
            Console.WriteLine(a.Remove(5, 1));

            //Replace
            Console.WriteLine(a.Replace(" ", ""));
            Console.WriteLine(b.Replace(" ", "---"));

            //Split
            Console.WriteLine(a.Split(" ")[1]);

            //Substring
            Console.WriteLine(a.Substring(6));
            Console.WriteLine(a.Substring(0, 7));


            Console.ReadKey();
        }
    }
}