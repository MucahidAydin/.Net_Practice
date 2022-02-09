using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayı");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayı");
                    break;
                case 3:
                    Console.WriteLine("Mart ayı");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayı");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayı");
                    break;
                default:
                    Console.WriteLine("Yanlış veri");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar Mevsimi");
                    break;
                default:                    
                    break;
            }
            Console.ReadKey();
        }
    }
}