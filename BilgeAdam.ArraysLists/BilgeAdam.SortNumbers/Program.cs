using System;

namespace BilgeAdam.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[20] { 34, 3, 12, 15, -3,  6, 30, 32, -35, 9, 0, 4, 12, -7, 4, -1, 6, 6, 7, -45};
            WriteNumbers(numbers);
            Console.WriteLine();
            var canContinue = true;
            while (canContinue)
            {
                canContinue = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if ((i + 1) == numbers.Length)
                    {
                        continue;
                    }
                    var first = numbers[i];
                    var second = numbers[i + 1];
                    if (first > second)
                    {
                        numbers[i] = second;
                        numbers[i + 1] = first;
                        canContinue = true;
                    }
                }
            }
            WriteNumbers(numbers);
            Console.ReadKey();
        }

        static void WriteNumbers(int[] arrayToWrite)
        {
            for (var i = 0; i < arrayToWrite.Length; i++)
            {
                Console.Write("{0} ", arrayToWrite[i]);
            }
        }
    }
}
