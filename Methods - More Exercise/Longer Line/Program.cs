double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double y4 = double.Parse(Console.ReadLine());
LongerLine(x1,y1,x2,y2,x3,y3,x4,y4);
static bool Closer(double x1, double y1, double x2, double y2)
{
    bool isFirstCloser = false;
    if (Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(x2, 2) + Math.Pow(y2, 2))
    {
        isFirstCloser = true;
    }
    else
    {
        isFirstCloser = false;
    }
    return isFirstCloser;
}
static void LongerLine(double x1,double y1, double x2, double y2, double x3, double y3, double x4, double y4)
{


    double firstLine = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    double secondLine = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
    if (firstLine >= secondLine)
    {
        bool isFirstCloser = Closer(x1, y1, x2, y2);
        if (isFirstCloser)
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
    }
    else
    { 
        bool isFirstCloser = Closer(x3, y3, x4, y4);
        if (isFirstCloser)
        {

         Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
        }
        else Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
    }
}