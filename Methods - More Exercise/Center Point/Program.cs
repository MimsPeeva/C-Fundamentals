namespace Center_Point
{
    internal class Program
    {
        private static object esle;

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
           Console.WriteLine( CenterPoint(x1,y1,x2,y2));
        }
        static string CenterPoint(double x1, double y1, double x2, double y2)
        {
            double result1 = Math.Abs(x1) +Math.Abs(y1);
            double result2 = Math.Abs(x2) + Math.Abs(y2);
            if (result1 > result2) { string result = "(" + x2.ToString() + "," +" " + y2.ToString() + ")"; return result; }
            else { string result = "(" + x1.ToString() + "," + " "+y1.ToString() + ")"; return result; }
        }
    }
}