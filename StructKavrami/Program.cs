using System;

namespace StructKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.KisaKenar = 10;
            dikdortgen1.Uzunkenar = 20;
            Console.WriteLine(dikdortgen1.Alanhesapla());
            //Console.WriteLine(dikdortgen1.Alanhesapla());

            Dikdortgen dikdortgen2 = new Dikdortgen();
            dikdortgen2.Uzunkenar = 20;
            Console.WriteLine(dikdortgen2.Alanhesapla());

            DikdortgenStruct dikdortgenStruct1 = new DikdortgenStruct();
            dikdortgenStruct1.KisaKenar = 10;
            dikdortgenStruct1.Uzunkenar = 20;
            Console.WriteLine(dikdortgenStruct1.Alanhesapla());

            DikdortgenStruct dikdortgenStruct2;//kurucu metot kullanamayız.
            dikdortgenStruct2.KisaKenar = 5;
            dikdortgenStruct2.Uzunkenar = 15;
            Console.WriteLine(dikdortgenStruct2.Alanhesapla());

            DikdortgenStruct dikdortgenStruct3 = new DikdortgenStruct();
            //dikdortgenStruct3.KisaKenar = 10;
            //dikdortgenStruct3.Uzunkenar = 20;
            Console.WriteLine(dikdortgenStruct3.Alanhesapla());

            Console.ReadKey();
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int Uzunkenar;
        public Dikdortgen()//varsayılan
        {
            KisaKenar = 3;
            Uzunkenar = 4;
        }
        public long Alanhesapla()
        {
            return this.KisaKenar * this.Uzunkenar;
        }
    }
    struct DikdortgenStruct
    {
        public int KisaKenar;
        public int Uzunkenar;
        public DikdortgenStruct()
        {
            KisaKenar = 4;
            Uzunkenar = 7;
        }
        public long Alanhesapla()
        {
            return this.KisaKenar * this.Uzunkenar;
        }
    }
}