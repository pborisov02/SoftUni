using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] array2 = new int[array.Length];
            for (int p = 0; p < rotations; p++)
            {
                int n = array[0];
                for(int b = 0; b < array.Length-1; b++)
                {
                    array2[b] = array[b + 1];
                }
                array2[array.Length - 1] = n;
                array = array2;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
