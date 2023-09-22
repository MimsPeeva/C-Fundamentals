using System;

namespace Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int factorial = 1;
                int currentN = int.Parse(n[i].ToString());
                for (int j = 1; j <= currentN; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
               
            if ( sum == int.Parse(n)) { Console.WriteLine("yes"); }
            else Console.WriteLine("no");
        }
    }
}
