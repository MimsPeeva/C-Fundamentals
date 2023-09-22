using System;
using System.Xml.Schema;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double money = 0;
            double sum = 0;
            for (int i = 1; i <=n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                money = pricePerCapsule * days * capsulesCount;
                sum += money;
                Console.WriteLine($"The price for the coffee is: ${money:f2}");
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
