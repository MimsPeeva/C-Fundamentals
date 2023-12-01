using System.Text.RegularExpressions;

int totalCalories = 0;
int days = 0;
int nutrition = 0;
string pattern = @"(\||\#)(?<itemName>\w+\s\w+|\w+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<nutrition>\d+)\1";
string input = Console.ReadLine();
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match match in matches)
{
    nutrition += int.Parse(match.Groups["nutrition"].Value);
}
days = nutrition / 2000;
 Console.WriteLine($"You have food to last you for: {days} days!");
foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups["itemName"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["nutrition"].Value}");
}
//#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|