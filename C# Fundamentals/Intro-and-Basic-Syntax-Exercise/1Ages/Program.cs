using System;

namespace CSharp_Fundamentals_Intro_and_Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result =
                input <= 2 ? "baby" :
                input <= 13 ? "child" :
                input <= 19 ? "teenager" :
                input <= 65 ? "adult" : "elder";
            Console.WriteLine(result);
        }
    }
}
