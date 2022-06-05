using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if(groupType == "Students")
            {
                if (day == "Friday")
                    price = peopleCount * 8.45;
                else if (day == "Saturday")
                    price = peopleCount * 9.80;
                else if (day == "Sunday")
                    price = peopleCount * 10.46;
                if (peopleCount >= 30)
                    price -= price * 0.15;
            }

            else if (groupType == "Business")
            {
                if (day == "Friday")
                    price = peopleCount * 10.90;
                else if (day == "Saturday")
                    price = peopleCount * 15.60;
                else if (day == "Sunday")
                    price = peopleCount * 16;
                if (peopleCount >= 100)
                    price -= price / peopleCount * 10;
            }

            else if (groupType == "Regular")
            {

                if (day == "Friday")
                    price = peopleCount * 15;
                else if (day == "Saturday")
                    price = peopleCount * 20;
                else if (day == "Sunday")
                    price = peopleCount * 22.50;
                if (peopleCount >= 10 && peopleCount <= 20)
                    price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
