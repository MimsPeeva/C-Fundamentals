using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger f = 1;
for (int i = n; i >= 2; i--)
{
    f *= i;
}
Console.WriteLine(f);