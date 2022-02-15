using System;

namespace ExtensionMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    //Rekürsif - öz yinelemeli
		    //3^4
		    int result=1;
		    for (int i = 1; i < 5; i++)
			result*=3;              
		    Console.WriteLine(result);
		    int a=3;
		    Console.WriteLine(a.Expo(4));
		    metotlar instance =new metotlar();
		    Console.WriteLine(instance.Expo2(3,4));

		    string ifade = "Mücahid Aydin";
		    bool sonuc = ifade.CheckSpaces();
		    Console.WriteLine(sonuc);

		    if (sonuc)
		    {
			Console.WriteLine(ifade.RemoveWhiteSpaces());                               
		    }

		    Console.WriteLine(ifade.MakeLowerCase());
		    Console.WriteLine(ifade.MakeUpperCase());

		    int[] diziler = {5,56,446,54864,849,5,49,459,878,9495,78,45,54698,894,98,978,98,794,597,98489,7489,9};
		    diziler.SortArray();
		    diziler.EkranaYazdır();

		    int sayi = 7;
		    Console.WriteLine(sayi.IsEvenNumber());
		    Console.WriteLine(ifade.GetFirstCharacter());

		    int ilkSayi=14,ikinciSayi=66;
		    Console.WriteLine(ilkSayi.toplam(ikinciSayi));

		    Console.ReadKey();
		}     
	}
	
    public class metotlar
    {
       public int Expo2(int a,int b)
       {
             if (b < 2)
                return a;
            return Expo2(a, b - 1) * a;
           
       }
    }

    public static class Extension
    {       
                              //(a=3,4)
        public static int Expo(this int a,int b)
        {   
            int result=1;
            for (int i = 1; i < (b+1); i++)
                result*=a;
            return result; 
        }
        public static bool CheckSpaces(this string param)
        {
           return param.Contains("");
           //param.Contains("");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("-",dizi);
            //string.Join("-",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static int toplam(this int a,int b)
        {
            return a+b;
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdır(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
            
        }
        public static bool IsEvenNumber(this int param)
        {
            
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param)
        {
             return param.Substring(0,7);
             //param.Substring(0,1);
            
        }
    }
}
