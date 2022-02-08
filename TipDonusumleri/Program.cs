using System;

namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("**** IMPLICIT ****");
            byte a = 5;
            sbyte b = 30;
            short c  =10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Ahmet";
            char f = 'k';
            object o = e+f+d;
            Console.WriteLine("o: " + o);



            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("**** EXPLICIT ****");
            int x = 4;
            
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);            
            
            
            
            Console.WriteLine("**** TOSTRING ****");
            int xx = 6;

            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);



            //Convert
            Console.WriteLine("**** CONVERT ****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);


            // Parse
            Console.WriteLine("**** PARSE ****");
            ParseMethod();       
            
            
            Console.ReadKey();
        }

        public static void ParseMethod()
        {
            string m1 = "10";
            string m2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(m1);
            double1 = Double.Parse(m2);

            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);


        }
    }
}