using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowBallsCount = int.Parse(Console.ReadLine());
            BigInteger highestSnowBallValue = 0;
            int highestSnowBallSnow = 0;
            int highestSnowBallTime = 0;
            int highestSnowBallQuality = 0;
            for (int i = 1; i <= snowBallsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow/snowballTime,snowballQuality);
                if (snowballValue >= highestSnowBallValue)
                { highestSnowBallValue = snowballValue;
                    highestSnowBallSnow = snowballSnow;
                    highestSnowBallTime = snowballTime;
                    highestSnowBallQuality = snowballQuality;   
                }
            }
            Console.WriteLine($"{highestSnowBallSnow} : {highestSnowBallTime} = {highestSnowBallValue} ({highestSnowBallQuality})");
        }
    }
}
