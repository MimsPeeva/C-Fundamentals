namespace Data_Types
{
    internal class Program
    {
        public class DataTypes
        {
            static void Main(string[] args)
            {
                string type = Console.ReadLine();

                switch (type)
                {
                    case "int":
                        int inputInt = int.Parse(Console.ReadLine());
                        int resultInt = Output(inputInt);
                        Console.WriteLine(resultInt);
                        break;
                    case "real":
                        double inputDouble = double.Parse(Console.ReadLine());
                        double resultDouble = Output(inputDouble);
                        Console.WriteLine($"{resultDouble:f2} ");
                        break;
                    case "string":
                        string input = Console.ReadLine();
                        string resultStr= Output(input);
                        Console.WriteLine(resultStr);
                        break;
                }
          
            }
            public static int Output(int input)
            {
                return input*2;
            }
            public static double Output(double input)
            {
                return input*1.5;
            }
            public static string Output( string input)
            {
                return "$"+input+"$";
            }
        }
    }
}