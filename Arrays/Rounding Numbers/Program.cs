using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] rounded = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                rounded[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {rounded[i]}");
            }
        }
    }
}
