using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadSet = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int headSetTrashed = lostGames / 2;
            int mouseTrashed = lostGames / 3;
            int keyBoadrTrashed = lostGames / 6;
            int displayTrashed = lostGames / 12;

            double sum = priceHeadSet * headSetTrashed + priceMouse * mouseTrashed + priceKeyboard * keyBoadrTrashed + priceDisplay * displayTrashed;

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
    }
}
