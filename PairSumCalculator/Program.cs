using System;

namespace PairSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen integer ikililerini girin (örneğin: 2 3 1 5 2 5 3 3):");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);

            if (numbers.Length % 2 != 0)
            {
                Console.WriteLine("Lütfen ikililerin tamamlanması için çift sayıda integer girin.");
                return;
            }

            for (int i = 0; i < numbers.Length; i += 2)
            {
                int a = numbers[i];
                int b = numbers[i + 1];
                int sum = a + b;

                if (a == b)
                {
                    Console.Write(sum * sum + " ");
                }
                else
                {
                    Console.Write(sum + " ");
                }
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
