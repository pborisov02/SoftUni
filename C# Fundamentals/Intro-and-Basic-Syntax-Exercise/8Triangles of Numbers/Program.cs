using System;

namespace Triangles_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; i < input; i++)
            {
                int n = input;
                for (int j = 0; j < counter ; j++)
                {
                    Console.Write(counter + " ");
                }
                Console.WriteLine();
                counter++;
                n--;
            }
        }
    }
}
