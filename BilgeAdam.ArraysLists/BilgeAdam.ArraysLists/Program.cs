using System;

namespace BilgeAdam.ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = 0;
            var numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Bir Sayı Giriniz.....: ");
                var number = int.Parse(Console.ReadLine());
                numbers[i] = number;
                summary += number;
            }
            
            Console.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Toplam......: {0}", summary);
            Console.WriteLine("Ortalama....: {0}", summary / Convert.ToDouble(numbers.Length)); // BLACK F DON'T HORSE :D sürpriz
            Console.ReadLine();
        }
    }
}
