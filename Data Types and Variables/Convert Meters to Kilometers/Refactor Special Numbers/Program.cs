using System;

namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int ch = 1; ch <= n; ch++)
            {
                int sum = 0;
               int digits = ch;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }
              bool  isSpecialNum = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine("{0} -> {1}", ch, isSpecialNum);
               
            }
        }
    }
}
