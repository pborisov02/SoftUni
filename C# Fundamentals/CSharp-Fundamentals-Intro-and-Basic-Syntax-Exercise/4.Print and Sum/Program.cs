using System;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                result += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {result}");
        }
    }
}
