using System;

namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int code = (int)(symbol);
            if (code >= 65 && code <= 90) { Console.WriteLine("upper-case"); }
            else Console.WriteLine("lower-case");
        }
    }
}
