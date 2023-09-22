using System;

namespace Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <=n2; i++)
            {
               
                Console.Write((char)i + " ");
            }
        }
    }
}
