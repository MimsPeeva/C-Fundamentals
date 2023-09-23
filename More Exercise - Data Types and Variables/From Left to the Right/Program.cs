using System;

namespace From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string stringBeforeSpace = numbers.Substring(0, numbers.IndexOf(" "));
                string stringAfterSpace = numbers.Substring(numbers.IndexOf(" ") + 1);
                long numLeft = long.Parse(stringBeforeSpace);
                long numRight = long.Parse(stringAfterSpace);
                long sumDigits = 0;
                if (numLeft >= numRight)
                {
                    while (numLeft != 0)
                    {
                        sumDigits += numLeft % 10;
                        numLeft /= 10;
                    }
                }
                else {
                    while (numRight != 0)
                    {
                        sumDigits += numRight % 10;
                        numRight /= 10;
                    }
                    
                }
                Console.WriteLine(Math.Abs(sumDigits));
            }
          
        }
    }
}
