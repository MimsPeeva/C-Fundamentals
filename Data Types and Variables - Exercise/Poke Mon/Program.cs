using System;

namespace Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int target = 0;
            double percentage = (double)0.5 * N;
            while (N >= M)
            {
               
                target++;
                N -= M;
                if (N == percentage&&Y!=0)
                {
                    
                        N /=  Y;
                    
                }
               
            }
            Console.WriteLine(N);
            Console.WriteLine(target);
        }
    }
}
