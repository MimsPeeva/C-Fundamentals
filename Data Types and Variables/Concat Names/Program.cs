using System;

namespace Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string delimiter = Console.ReadLine();
            string resuts = name + delimiter+ surname;
            Console.WriteLine(resuts);
        }
    }
}
