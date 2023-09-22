using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
         
            int freeBelts = studentsNumber / 6;
            double neededMoney = Math.Ceiling(studentsNumber * 1.1) * priceLightsaber + priceRobe * studentsNumber + (studentsNumber-freeBelts) * priceBelt;
        
            if (money >= neededMoney) { Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv."); }
            else Console.WriteLine($"John will need {Math.Abs(neededMoney-money):f2}lv more.");
        }
    }
}
