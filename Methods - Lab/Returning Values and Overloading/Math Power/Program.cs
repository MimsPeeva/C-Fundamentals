static double Power(double basee, double power)
{
    double result = Math.Pow(basee, power);
    return result;
}
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double result = Power(a, b);
Console.WriteLine(result);