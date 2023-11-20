using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\s*\+[359]\d+( |-)\d\1\d{3}\1\d{4}";
            string input = Console.ReadLine();
            Regex reg = new Regex(patern);
            MatchCollection match = reg.Matches(input);

            var matches = match.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
                Console.WriteLine(string.Join(", ", matches));
            
        }
    }
}
//*+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 2222222 + 359 2 - 222 - 2222, +359 - 2 - 222 - 222, +359 - 2 - 222 - 22222 + 359 -2 - 222 - 2222