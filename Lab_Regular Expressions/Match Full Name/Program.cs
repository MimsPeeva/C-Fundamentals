using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            string input = Console.ReadLine();
            Regex reg = new Regex(patern);
            MatchCollection matches = reg.Matches(input);
            foreach (Match item in matches)
            {
                Console.Write($"{item.Value} ");
            }
        }
    }
}