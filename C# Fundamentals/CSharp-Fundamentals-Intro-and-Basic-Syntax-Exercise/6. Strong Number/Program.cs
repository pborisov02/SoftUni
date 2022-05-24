using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //40585 24 + 120 + 120 + 40320
            //Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.
            //Example: 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes", if the number is strong and "no", if the number is not strong.
            int input = int.Parse(Console.ReadLine());
            int inputCopy = input;
            int result = 0;
            while (input != 0)
            {
                int num = input % 10;
                int remainder = num;
                input /= 10;
                for (int i = 1; i < remainder ; i++)
                {
                    num *= i;  
                }
                if (remainder == 0)
                    result += 1;
                result += num;
            }
            if(inputCopy == result)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
