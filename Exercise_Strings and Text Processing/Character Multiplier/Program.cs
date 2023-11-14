using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] arguments = Console.ReadLine().Split();
        Console.WriteLine(Sum(arguments[0], arguments[1]));
        
    }
    private static int Sum(string first, string second)
    {
        int totalSum = 0;
        int length = Math.Max(first.Length, second.Length);
        for (int i = 0; i < length; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                totalSum += first[i] * second[i];
            }
            else if (i < first.Length)
            {
                totalSum += first[i];
            }
            else if (i < second.Length)
            {
                totalSum += second[i];
            }
        }

        return totalSum;
    }
}