namespace Metotlar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a=4,b=3;
            metotlar ornek=new metotlar();
            ornek.EkranaYazdır(toplam(a,b));
            
            ornek.ArtırVeTopla(ref a,ref b);
            ornek.EkranaYazdır(toplam(a,b));
            
            Console.ReadKey();

            
		}
        static int toplam(int deger1,int deger2)
        {
            return deger1+deger2;
        }

	}
    class metotlar
    {
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(Convert.ToString(veri));
        }

        public int ArtırVeTopla(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2+=10;
            return deger1+deger2;
        }
    }
}