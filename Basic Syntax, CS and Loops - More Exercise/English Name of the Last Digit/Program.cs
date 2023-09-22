using System;

namespace English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 1) { Console.WriteLine("one"); }
            else if (n % 10 == 2) { Console.WriteLine("two"); }
            else if (n % 10 == 3) { Console.WriteLine("three"); }
            else if (n % 10 == 4) { Console.WriteLine("four"); }
            else if (n % 10 == 5) { Console.WriteLine("five"); }
            else if (n % 10 == 6) { Console.WriteLine("six"); }
            else if (n % 10 == 7) { Console.WriteLine("seven"); }
            else if (n % 10 == 8) { Console.WriteLine("eight"); }
            else if (n % 10 == 9) { Console.WriteLine("nine"); }
            else if (n % 10 == 0) { Console.WriteLine("zero"); }
        }
    }
}
