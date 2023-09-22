using System;

namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            double km = m*0.001;
            Console.WriteLine($"{km:f2}");
        }
    }
}
