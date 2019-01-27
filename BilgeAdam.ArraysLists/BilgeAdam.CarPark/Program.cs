using System;

namespace BilgeAdam.CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Car Park - Otopark Yönetimi";
            var sh = new ScreenHelper();
            while (true)
            {
                Console.Write(" ======----===== CarPARK Menüsü ======----===== ");
                Console.WriteLine();
                Console.WriteLine("Araç Girişi......: G");
                Console.WriteLine("Araç Çıkışı......: C");
                Console.WriteLine("Araç Listesi.....: L");
                Console.WriteLine("Hasılat Ekranı...: H");
                Console.Write("Seçiminiz........: ");
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.G:
                        sh.GetCarInfoToAdd();
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Araç Çıkışı Yapılacak");
                        break;
                    case ConsoleKey.L:
                        sh.GetParkInfo();
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("Hasılat");
                        break;
                }
                Console.WriteLine("Devam etmek için bir tuşa basınız");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
