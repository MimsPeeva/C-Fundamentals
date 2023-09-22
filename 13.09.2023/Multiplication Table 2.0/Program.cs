using System;

namespace Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (d < 10)
            {
                for (int i = d; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n*i}");
                }
            }
            else Console.WriteLine($"{n} X {d} = {n*d}");
        }
    }
}
