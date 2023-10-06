static int Area(int a,int b)
{
    return a * b;
}
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int area = Area(a,b);
Console.WriteLine(area);