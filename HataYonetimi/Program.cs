using System;

namespace HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı: " + sayi1);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally{
                Console.WriteLine("Hata alınsın veya alınmasın bu mesaj gösterilecektir.");
            }
            
          try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Girilen veri tipi uygun değil");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Girilen değer çok küçük yada çok büyük");
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}