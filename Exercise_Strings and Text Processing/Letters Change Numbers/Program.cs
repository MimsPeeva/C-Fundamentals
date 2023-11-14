namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] {' ' }, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;
            foreach (var str in input)
            {
                char letterBefore = str[0];
                char letterAfter = str[str.Length-1];
                decimal postition;
                decimal number = decimal.Parse(str.Substring(1,str.Length-2));
                decimal result = 0;
                if (char.IsUpper(letterBefore))
                {
                    postition = letterBefore-'A'+1;
                    result = number / postition;
                }
                else if (char.IsLower(letterBefore))
                {
                    postition = letterBefore - 'a' + 1;
                    result = number * postition;
                }
                if (char.IsUpper(letterAfter))
                {
                    postition = letterAfter - 'A' + 1;
                    result -=  postition;
                }
                else if (char.IsLower(letterAfter))
                {
                    postition = letterAfter - 'a' + 1;
                    result += postition;
                }
                totalSum += result;
            }
           Console.WriteLine($"{totalSum:f2}");
        }
    }
}
