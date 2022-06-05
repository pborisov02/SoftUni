using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //As a MOBA challenger player, Petar has the bad habit of trashing his PC when he loses a game and of rage quiting. His gaming setup consists of a headset, mouse, keyboard, and display. You will receive Petar's lost games count. 
            //Every second lost game, Petar trashes his headset.
            //Every third lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every second time, when he trashes his keyboard, he also trashes his display.
            //You will receive the price of each item in his gaming setup.Calculate his rage expenses for renewing his gaming equipment.
            //Input / Constraints
            //•	On the first input line – lost games count – integer in the range[0…1000].
            //•	On the second line – headset price – floating - point number in the range[0…1000].
            //•	On the third line – mouse price – floating - point number in the range[0…1000].
            //•	On the fourth line – keyboard price – floating - point number in the range[0…1000].
            //•	On the fifth line – display price – floating - point number in the range[0… 1000].
            //Output
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
            //•	Allowed working time / memory: 100ms / 16MB.

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int brokenMices = lostGames / 3;
            int brokenHeadsets = lostGames / 2;
            int brokenKeyboards = lostGames / 6;
            int brokenDisplays = brokenKeyboards / 2;
            double rageExpenses = mousePrice * brokenMices + keyboardPrice * brokenKeyboards + displayPrice * brokenDisplays + headsetPrice * brokenHeadsets;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
