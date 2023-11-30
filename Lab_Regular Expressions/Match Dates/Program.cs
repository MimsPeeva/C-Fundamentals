using System.Text.RegularExpressions;

namespace Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\/|\.|\-)(?<month>\w{3})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();
            var match = Regex.Matches(input, pattern);
            foreach (Match item in match)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
           
        }
    }
    }
