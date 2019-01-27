using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.CarPark
{
    class ScreenHelper
    {
        ParkManager manager = new ParkManager();
        public void GetCarInfoToAdd()
        {
            Console.WriteLine();
            Console.WriteLine("==== YENİ ARAÇ GİRİŞİ ====");
            Console.Write("Plaka Giriniz......: ");
            var plate = Console.ReadLine();

            manager.SaveCar(plate);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Araç Kaydedildi");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GetParkInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Sıra\tPlaka\t\tGiriş Saati");
            DrawLine('=');
            var cars = manager.GetCars();
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    Console.WriteLine(i + 1);
                    DrawLine('_');
                    continue;
                }
                Console.WriteLine("{0}\t{1}\t\t{2}", i + 1, cars[i].plate, cars[i].entrance);
                DrawLine('_');
            }

            Console.WriteLine();
        }

        private void DrawLine(char symbol)
        {
            for (int i = 0; i < 56; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}
