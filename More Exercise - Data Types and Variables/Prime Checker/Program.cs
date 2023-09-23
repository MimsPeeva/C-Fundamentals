using System;

namespace Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool primeNumber = true;
                for (int cepitel = 2; cepitel < i; cepitel++)
                {
                    if (i % cepitel == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                string result = primeNumber.ToString();
                result = result.ToLower();
                Console.WriteLine("{0} -> {1}", i, result);
            }
        }
    }
}
