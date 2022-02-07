using System;

namespace operatorler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
        

           bool isSuccess = true;
           bool isCompelted = false;

           if (isSuccess && isCompelted )
           Console.WriteLine("Wonderfull!");

           if (isSuccess || isCompelted )
           Console.WriteLine("Excellent!");

           if (isSuccess && !isCompelted )
           Console.WriteLine("Good!");


         

           int c =99;
           int d =6;
           bool sonuc = c<d;           
           Console.WriteLine(sonuc);
           sonuc = d<c;
           Console.WriteLine(sonuc);
           sonuc = d==c;
           Console.WriteLine(sonuc);
           sonuc = d>=c;
           Console.WriteLine(sonuc);
           sonuc = d<=c;

        

           int g =46;
           int h =50;
           int sonuc1 = g + h;
           Console.WriteLine(sonuc1);
           sonuc1 = g + h;
           Console.WriteLine(sonuc1);
           sonuc1 = g * h;
           Console.WriteLine(sonuc1);
           sonuc1 = g / h;
           Console.WriteLine(sonuc1);
           sonuc1 = h++;
           Console.WriteLine(sonuc1);

      

           int kalan = 20%3;
           Console.WriteLine(kalan);
        }
    }
}