using System;

namespace MetotOverloading
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sayi="100";

            bool sonuc = int.TryParse(sayi,out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            
            metotolar instance =new metotolar();
            instance.toplam(4,7,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);
            
            instance.EkranaYazdir(47);
            instance.EkranaYazdir(Convert.ToString(47));
            instance.EkranaYazdir("Mücahid","Aydin");

            Console.ReadKey();
		}
	}

    class metotolar
    {

        public void toplam(int a,int b,out int toplam)
        {
            toplam=a+b;
        }
        //Metot Aşırı Yükleme - Overloading
        //metotAdı + parametre sayısı + parametre tipi
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri,string veri2)
        {
            Console.WriteLine(veri+" "+veri2);
        }
    }
}