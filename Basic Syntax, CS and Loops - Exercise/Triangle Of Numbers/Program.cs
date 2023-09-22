using System;
using System.Runtime.CompilerServices;

namespace Triangle_Of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            { for (int j = 1; j <= i; j = j + 1)
                { Console.Write(i + " "); }
                Console.WriteLine();
            }
           
        }
    }
}
