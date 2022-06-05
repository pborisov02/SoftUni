using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] train = new int[wagons];
            int passengers = 0;
            for (int p = 0; p < wagons; p++)
            {
                train[p] = int.Parse(Console.ReadLine());
                passengers += train[p];
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(passengers);
        }
    }
}

