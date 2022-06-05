using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for(int p = 0; p < array.Length; p++)
            {
                bool isTopInteger = true;
                for (int b = p + 1; b < array.Length; b++)
                {
                    if (array[p] <= array[b])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if(isTopInteger)
                    Console.Write(array[p] + " ");
            }
        }
    }
}
