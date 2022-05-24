using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {

            double budged = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double lightsabersCount = studentsCount + Math.Ceiling(studentsCount * 0.1);
            int beltCount = studentsCount - studentsCount / 6;
            int robesCount = studentsCount;
            double price = lightsaberPrice * lightsabersCount + robesPrice * robesCount + beltPrice * beltCount;
            if(price <= budged)
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            else
                Console.WriteLine($"John will need {price - budged:f2}lv more.");
        }
    }
}
