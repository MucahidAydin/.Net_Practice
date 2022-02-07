using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            uint a = 10;   //4 byte
            ulong b= 20;   //8 byte

            float float1 = 7;         //4 byte
            double double1 = 15.9;    //8 byte
            
            object object1="mucahid";
            object object2=21;
            object object3=4.4;


            string str1=string.Empty;
            str1="15";

            int str2=Convert.ToInt32(str1);
            Console.WriteLine(str2);

            string str3=str1.ToString();
            Console.WriteLine(str3);

            int str4=int.Parse(str3);
            Console.WriteLine(str4);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            
            
            Console.ReadKey();

        }
    }
}
