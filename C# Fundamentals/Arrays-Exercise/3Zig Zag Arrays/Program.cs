using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputValues = input.Split(' ');
                if (i % 2 == 0)
                {
                    arr1[i] = inputValues[0];
                    arr2[i] = inputValues[1];
                }
                else if (i % 2 == 1)
                {
                    arr1[i] = inputValues[1];
                    arr2[i] = inputValues[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
