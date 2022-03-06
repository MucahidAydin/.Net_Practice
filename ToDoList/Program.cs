using System;

namespace ToDoList
{
    internal class Program
    {
        public static List<Card> Todu = new List<Card>();
        public static List<Card> InProgress = new List<Card>();
        public static List<Card> Done = new List<Card>();
        public static Dictionary<string, string> TakımUyeler = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            TakımUyeler.Add("001", "Mücahid Aydin");
            TakımUyeler.Add("002", "Zikriye Ürkmez");
            TakımUyeler.Add("003", "Hakan Tuna");
            TakımUyeler.Add("004", "Ahmet Boy");

            Todu.Add(new Card() { baslık = "alınacaklar", icerik = "Havuç", atananKisi = "0001", buyukluk = "XS" });
            Todu.Add(new Card() { baslık = "kitap", icerik = "Soru bankası", atananKisi = "003", buyukluk = "L" });
            Todu.Add(new Card() { baslık = "alınacaklar", icerik = "Domates", atananKisi = "002", buyukluk = "M" });

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(0) Çıkış");
                Console.Write("Lütfen bir rakam giriniz : ");

                try
                {
                    int girdi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (girdi == 0)
                        break;
                    else if (girdi == 1)
                        getBoard(0, 0, 0);
                    else if (girdi == 2)
                        newCard();
                    else if (girdi == 3)
                        removeCard();
                    else if (girdi == 4)
                        moveCard();
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
        // --------------------- getBoard
        public static void getBoard(int mod, int indexNo, int listNo)
        {
            if (mod == 0)
            {
                Console.WriteLine("************************");
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
                if (Todu.Count == 0)
                    Console.WriteLine("~ BOŞ ~");
                else
                {
                    foreach (var item in Todu)
                    {
                        Console.WriteLine("Başlık      : {0}", item.baslık);
                        Console.WriteLine("İçerik      : {0}", item.icerik);
                        Console.WriteLine("Atanan Kişi : {0}", item.atananKisi);
                        Console.WriteLine("Büyüklük    : {0}", item.buyukluk);
                        Console.WriteLine(" -");
                    }
                }
                Console.WriteLine("************************");
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");
                if (InProgress.Count == 0)
                    Console.WriteLine("~ BOŞ ~");
                else
                {
                    foreach (var item in InProgress)
                    {
                        Console.WriteLine("Başlık      : {0}", item.baslık);
                        Console.WriteLine("İçerik      : {0}", item.icerik);
                        Console.WriteLine("Atanan Kişi : {0}", item.atananKisi);
                        Console.WriteLine("Büyüklük    : {0}", item.buyukluk);
                        Console.WriteLine(" -");
                    }
                }
                Console.WriteLine("************************");
                Console.WriteLine("DONE Line");
                Console.WriteLine("************************");
                if (Done.Count == 0)
                    Console.WriteLine("~ BOŞ ~");
                else
                {
                    foreach (var item in Done)
                    {
                        Console.WriteLine("Başlık      : {0}", item.baslık);
                        Console.WriteLine("İçerik      : {0}", item.icerik);
                        Console.WriteLine("Atanan Kişi : {0}", item.atananKisi);
                        Console.WriteLine("Büyüklük    : {0}", item.buyukluk);
                        Console.WriteLine(" -");
                    }
                }
            }
            else if (mod == 2)
            {
                if (listNo == 1)
                {
                    Console.WriteLine("Başlık      : {0}", Todu[indexNo].baslık);
                    Console.WriteLine("İçerik      : {0}", Todu[indexNo].icerik);
                    Console.WriteLine("Atanan Kişi : {0}", Todu[indexNo].atananKisi);
                    Console.WriteLine("Büyüklük    : {0}", Todu[indexNo].buyukluk);
                    Console.WriteLine("Line        : {0}", "TODO");
                }
                else if (listNo == 2)
                {
                    Console.WriteLine("Başlık      : {0}", InProgress[indexNo].baslık);
                    Console.WriteLine("İçerik      : {0}", InProgress[indexNo].icerik);
                    Console.WriteLine("Atanan Kişi : {0}", InProgress[indexNo].atananKisi);
                    Console.WriteLine("Büyüklük    : {0}", InProgress[indexNo].buyukluk);
                    Console.WriteLine("Line        : {0}", "IN PROGRESS");
                }
                else if (listNo == 3)
                {
                    Console.WriteLine("Başlık      : {0}", Done[indexNo].baslık);
                    Console.WriteLine("İçerik      : {0}", Done[indexNo].icerik);
                    Console.WriteLine("Atanan Kişi : {0}", Done[indexNo].atananKisi);
                    Console.WriteLine("Büyüklük    : {0}", Done[indexNo].buyukluk);
                    Console.WriteLine("Line        : {0}", "DONE");
                }
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                Console.Write("Lütfen bir rakam giriniz : ");
                int girdi = Convert.ToInt32(Console.ReadLine());

                if (girdi == 1)
                {
                    if (listNo == 2)
                    {
                        Todu.Add(InProgress[indexNo]);
                        InProgress.Remove(InProgress[indexNo]);
                    }
                    else if (listNo == 3)
                    {
                        Todu.Add(Done[indexNo]);
                        Done.Remove(Done[indexNo]);
                    }
                }
                else if (girdi == 2)
                {
                    if (listNo == 1)
                    {
                        InProgress.Add(Todu[indexNo]);
                        Todu.Remove(Todu[indexNo]);
                    }
                    else if (listNo == 3)
                    {
                        InProgress.Add(Done[indexNo]);
                        Done.Remove(Done[indexNo]);
                    }
                }
                else if (girdi == 3)
                {
                    if (listNo == 1)
                    {
                        Done.Add(Todu[indexNo]);
                        Todu.Remove(Todu[indexNo]);
                    }
                    else if (listNo == 2)
                    {
                        Done.Add(InProgress[indexNo]);
                        InProgress.Remove(InProgress[indexNo]);
                    }
                }
                getBoard(0, 0, 0);
            }
        }
        // --------------------- newCard
        public static void newCard()
        {
            Console.Write("Başlık Giriniz                                  : ");
            string Baslık = Console.ReadLine();
            Baslık = Baslık.ToLower();

            Console.Write("İçerik Giriniz                                  : ");
            string Icerik = Console.ReadLine();
            Icerik = Icerik.ToLower();

            try
            {
                Console.Write("Kişi Seçiniz                                    : ");
                string AtananKisi = Console.ReadLine();
                AtananKisi = AtananKisi.ToLower();
                Console.WriteLine("üye => " + TakımUyeler[AtananKisi]);

                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
                int buyuklukGirdi = Convert.ToInt32(Console.ReadLine());
                string temp = null;
                if (buyuklukGirdi > 0 && buyuklukGirdi < 6)
                {
                    if ((int)Buyukluk.XS == buyuklukGirdi)
                        temp = Buyukluk.XS.ToString();
                    else if ((int)Buyukluk.S == buyuklukGirdi)
                        temp = Buyukluk.S.ToString();
                    else if ((int)Buyukluk.M == buyuklukGirdi)
                        temp = Buyukluk.M.ToString();
                    else if ((int)Buyukluk.L == buyuklukGirdi)
                        temp = Buyukluk.L.ToString();
                    else if ((int)Buyukluk.XL == buyuklukGirdi)
                        temp = Buyukluk.XL.ToString();
                }
                else
                {
                    Console.WriteLine("Hatalı Girdi!");
                    Console.WriteLine("");
                    newCard();
                }
                Todu.Add(new Card() { baslık = Baslık, icerik = Icerik, atananKisi = AtananKisi, buyukluk = temp });
            }
            catch
            {
                Console.WriteLine("Hatalı Girdi!");
                Console.WriteLine("");
                newCard();
            }
        }
        enum Buyukluk
        {
            XS = 1, S, M, L, XL
        }
        // --------------------- removeCard
        public static void removeCard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write(" Lütfen kart başlığını yazınız: ");
            string remove = Console.ReadLine();
            remove = remove.ToLower();
            bool check = false;
            foreach (var item in Todu)
            {
                if (remove == item.baslık)
                {
                    Todu.Remove(item);
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1) ");
                Console.WriteLine("* Yeniden denemek için      : (2) ");
                Console.Write(" Seçimiziniz : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 2)
                    removeCard();
            }
        }
        // --------------------- moveCard
        public static async void moveCard()
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write(" Lütfen kart başlığını yazınız: ");
            string move = Console.ReadLine();
            bool check = false;

            if (check == false)
            {
                for (int i = 0; i < Todu.Count; i++)
                {
                    if (move == Todu[i].baslık)
                    {
                        getBoard(2, i, 1);
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    for (int i = 0; i < InProgress.Count; i++)
                    {
                        if (move == InProgress[i].baslık)
                        {
                            getBoard(2, i, 2);
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                    {
                        for (int i = 0; i < Done.Count; i++)
                        {
                            if (move == Done[i].baslık)
                            {
                                getBoard(2, i, 3);
                                check = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1) ");
                Console.WriteLine("* Yeniden denemek için      : (2) ");
                Console.Write(" Seçimiziniz : ");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 2)
                    moveCard();
            }
        }
    }
}