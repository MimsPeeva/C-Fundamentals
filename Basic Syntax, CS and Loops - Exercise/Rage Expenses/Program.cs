using System;
using System.Diagnostics;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;
            expenses += (lostGamesCount / 2)*headsetPrice;
            expenses += (lostGamesCount / 3)*mousePrice;
            expenses += (lostGamesCount / 6)*keyboardPrice;
            expenses += (lostGamesCount / 12) * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
