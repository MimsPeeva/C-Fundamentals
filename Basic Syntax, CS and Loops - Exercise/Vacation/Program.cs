using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            if (groupType == "Students")
            { switch (day)
                {
                    case "Friday": totalPrice = countPeople * 8.45;break;
                    case "Saturday": totalPrice = countPeople * 9.8; break;
                    case "Sunday": totalPrice = countPeople * 10.46; break;
                }
                if (countPeople >= 30) { totalPrice = totalPrice - totalPrice * 0.15; }
            }
            else if (groupType == "Business")
            {
                if (countPeople >= 100)
                {
                    switch (day)
                    {
                        case "Friday": totalPrice = (countPeople-10) * 10.9; break;
                        case "Saturday": totalPrice = (countPeople-10) * 15.6; break;
                        case "Sunday": totalPrice = (countPeople - 10) * 16; break;
                    }
                }
                else
                {
                    switch (day)
                    {
                        case "Friday": totalPrice = countPeople * 10.9; break;
                        case "Saturday": totalPrice = countPeople * 15.6; break;
                        case "Sunday": totalPrice = countPeople * 16; break;
                    }
                }
            }
            else if (groupType == "Regular")
            {
                switch (day)
                {
                    case "Friday": totalPrice = countPeople * 15; break;
                    case "Saturday": totalPrice = countPeople * 20; break;
                    case "Sunday": totalPrice = countPeople * 22.5; break;
                }
                if (countPeople >= 10&&countPeople<=20) { totalPrice = totalPrice - totalPrice * 0.05; }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
