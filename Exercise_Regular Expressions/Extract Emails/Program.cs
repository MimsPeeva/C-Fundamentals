using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^\.\-_]\b(?![\._\-])[A-Za-z0-9]+[\.\-_]*[A-Za-z0-9]+@[^\.\-](?:[A-Za-z\.\-]+\.)+[A-Za-z]+";
            string input = Console.ReadLine();
            MatchCollection match = Regex.Matches(input, pattern);
            for (int i = 0; i < match.Count; i++)
            {
                Console.WriteLine(match[i].Value.Trim(',',' ','\n'));
            }
        }
    }
}
/*
Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.
 */