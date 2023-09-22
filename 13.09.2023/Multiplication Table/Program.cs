using System;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int v = 1;
            
            for (int i = 1; i <= 10; i++)
            {
                v = n * i;
                Console.WriteLine($"{n} X {i} = {v}");
              
              
            }
        }
    }
}
