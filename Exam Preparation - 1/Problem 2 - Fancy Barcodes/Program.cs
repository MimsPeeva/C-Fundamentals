using System.Text;
using System.Text.RegularExpressions;
int n = int.Parse(Console.ReadLine());
string product = string.Empty;
string pattern = "@#+(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})@#+";
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);
    if (match.Success)

    {
        char[] split = match.Groups["barcode"].Value.ToCharArray();
        List<char>list=new List<char>();
        foreach (char ch in split)
        {
            if(char.IsDigit(ch))
            {
                list.Add(ch);
            }
        }
        string print = list.Count > 0 
            ?string.Join("", list) 
            : "00";
        Console.WriteLine($"Product group: {print}");

    }
    else
	{
		Console.WriteLine("Invalid barcode");
	}
    
   
    
}
/*
3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##
 */