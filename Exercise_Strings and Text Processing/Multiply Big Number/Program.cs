/*
923847238931983192462832102
4
*/
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        string bigN = Console.ReadLine();
        string multiplyN = Console.ReadLine();
        Console.WriteLine(Multiply(bigN, multiplyN));

    }

        private static string Multiply(string bigN, string multiplyN)
        {
        if (bigN == "0" || multiplyN == "0")
        {
            return "0";
        }
        int carry = 0;
        int multiplier = int.Parse(multiplyN);
        char[] result = new char[bigN.Length+1];
        for (int i = bigN.Length-1; i >= 0; i--)
        {
            int digit = int.Parse(bigN[i].ToString());
            int product = digit * multiplier + carry;
            result[i + 1] = (char)(product%10 + '0');
            carry = product/10;
        }
        if (carry > 0)
        {
            result[0] = (char)(carry + '0');
        }
        return new string(result).TrimStart('\0');
        }
}