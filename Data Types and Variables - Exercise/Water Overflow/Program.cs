using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sumLitters = 0;
            for (int i = 1; i <= n; i++)
            {
                
                int litters = int.Parse(Console.ReadLine());
                if (litters + sumLitters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!"); 
                }
              else  sumLitters += litters; 
               
            }
            Console.WriteLine(sumLitters);
        }
    }
}
