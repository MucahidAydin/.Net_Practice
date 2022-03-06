using System;

namespace TelefonRehberi
{
    internal class Program
    {
        public static List<Rehber> kisiler = new List<Rehber>();
        static void Main(string[] args)
        {

            kisiler.Add(new Rehber() { Isim = "mücahid", Soyad = "aydin", No = "11111111111" });
            kisiler.Add(new Rehber() { Isim = "furkan", Soyad = "yıldırım", No = "333333s3333333" });
            kisiler.Add(new Rehber() { Isim = "ferhat", Soyad = "yılmaz", No = "000000000000" });
            kisiler.Add(new Rehber() { Isim = "tamer", Soyad = "turan", No = "66666666666666" });
            kisiler.Add(new Rehber() { Isim = "zikriye", Soyad = "ürkmez", No = "4444444444" });

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Çıkış");
                Console.Write("Lütfen bir rakam giriniz : ");
                try
                {
                    int girdi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (girdi == 0)
                        break;
                    else if (girdi == 1)
                        ekle();
                    else if (girdi == 2)
                        Sil();
                    else if (girdi == 3)
                        Update();
                    else if (girdi == 4)
                        listele(0, 0);
                    else if (girdi == 5)
                        Search();
                    else
                    {
                        Console.WriteLine("Hatalı Girdi!");
                        Console.WriteLine("");
                    }
                }
                catch
                {
                    Console.WriteLine("Hatalı Girdi!");
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
        //------------------------------------------------ ekle
        public static void ekle()
        {
            Console.Write("Lütfen isim giriniz             : ");
            string Name = Console.ReadLine();
            Name = Name.ToLower();

            Console.Write("Lütfen soyad giriniz          : ");
            string Surname = Console.ReadLine();
            Surname = Surname.ToLower();

            Console.Write(" Lütfen telefon numarası giriniz : ");
            string PhoneNumber = Console.ReadLine();
            kisiler.Add(new Rehber() { Isim = Name, Soyad = Surname, No = PhoneNumber });
        }
        //------------------------------------------------ listele
        static void listele(int sorgu, int findIndex)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            if (sorgu == 0)
            {
                foreach (var item in kisiler)
                {
                    Console.WriteLine("isim:             {0}", item.Isim);
                    Console.WriteLine("Soyad:            {0}", item.Soyad);
                    Console.WriteLine("Telefon Numarası: {0}", item.No);
                    Console.WriteLine("");
                }
            }
            else if (sorgu == 2)
            {
                Console.WriteLine("isim:             {0}", kisiler[findIndex].Isim);
                Console.WriteLine("Soyad:            {0}", kisiler[findIndex].Soyad);
                Console.WriteLine("Telefon Numarası: {0}", kisiler[findIndex].No);
                Console.WriteLine("");
            }
        }
        //------------------------------------------------ Search
        static void Search()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.Write(" İsim veya soyad göre arama yapmak için: (1) , ");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)  ");
            Console.Write(" Seçimiziniz : ");
            try
            {
                int secim = Convert.ToInt32(Console.ReadLine());

                bool kontrol = false;
                if (secim == 1)
                {
                    Console.Write("İsim veya soyad giriniz : ");
                    string search = Console.ReadLine();
                    Console.WriteLine("**********************************************");
                    for (int i = 0; i < kisiler.Count; i++)
                    {
                        if (search == kisiler[i].Isim)
                        {
                            listele(2, i);
                            kontrol = true;
                        }
                        else if (search == kisiler[i].Soyad)
                        {
                            listele(2, i);
                            kontrol = true;
                        }
                        else
                        {
                            if (i == (kisiler.Count - 1) && kontrol == false)
                                Console.WriteLine("aradıgınız sonuç bulunamadı.");
                        }
                    }
                    kontrol = false;
                }
                else if (secim == 2)
                {
                    Console.Write("Telefon numarasına giriniz : ");
                    string search = Console.ReadLine();
                    Console.WriteLine("**********************************************");
                    for (int i = 0; i < kisiler.Count; i++)
                    {
                        if (search == kisiler[i].No)
                        {
                            listele(2, i);
                            kontrol = true;
                        }
                        else
                        {
                            if (i == (kisiler.Count - 1) && kontrol == false)
                                Console.WriteLine("aradıgınız sonuç bulunamadı.");
                        }
                    }
                    kontrol = false;
                }
                else
                {
                    Console.WriteLine("Hatalı Girdi!");
                    Console.WriteLine("");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı Girdi!");
                Console.WriteLine("");
            }
        }
        //------------------------------------------------ Sil
        static void Sil()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string sil = Console.ReadLine();
            bool kontrol = false;

            for (int i = 0; i < kisiler.Count; i++)
            {
                if (sil == kisiler[i].Isim)
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", sil);
                    string cevap = Console.ReadLine();

                    if (cevap == "Y" || cevap == "y")
                    {
                        kisiler.Remove(kisiler[i]);
                        kontrol = true;
                        Console.WriteLine("Silindi");
                        break;
                    }
                    else if (cevap == "N" || cevap == "n")
                    {
                        kontrol = true;
                        Console.WriteLine("Silinmedi");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Girdi!");
                        Console.WriteLine("");
                    }
                }
                else if (sil == kisiler[i].Soyad)
                {
                    Console.WriteLine("{0} Soyadlı kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", sil);
                    string cevap = Console.ReadLine();

                    if (cevap == "Y" || cevap == "y")
                    {
                        kisiler.Remove(kisiler[i]);
                        kontrol = true;
                        break;
                    }
                    else if (cevap == "N" || cevap == "n")
                    {
                        kontrol = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Girdi!");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    if (i == (kisiler.Count - 1) && kontrol == false)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                        Console.WriteLine("* Yeniden denemek için      : (2) ");
                        Console.Write(" Seçimiziniz : ");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 2)
                            Sil();
                    }
                }
            }
            kontrol = false;
        }
        //------------------------------------------------ Güncelleme
        static void Update()
        {
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string update = Console.ReadLine();
            bool kontrol = false;
            int deger = 0;

            for (int i = 0; i < kisiler.Count; i++)
            {
                if (update == kisiler[i].Isim)
                {
                    kontrol = true;
                    deger = i;
                    break;
                }
                else if (update == kisiler[i].Soyad)
                {
                    kontrol = true;
                    deger = i;
                    break;
                }
                else
                {
                    if (i == (kisiler.Count - 1) && kontrol == false)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1) ");
                        Console.WriteLine("* Yeniden denemek için              : (2) ");
                        Console.Write(" Seçimiziniz : ");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 2)
                            Update();
                    }
                }
            }
            if (kontrol == true)
            {
                listele(2, deger);
                Console.Write("Yeni numarayın girinizi : ");
                string YeniNo = Console.ReadLine();
                kisiler[deger].No = YeniNo;
                listele(2, deger);
            }
            kontrol = false;
        }
    }
    //------------------------------------------------ Rehber
    public class Rehber
    {
        private string ısim;
        private string soyad;
        private string no;

        public string Isim { get => ısim; set => ısim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string No { get => no; set => no = value; }
    }
}
