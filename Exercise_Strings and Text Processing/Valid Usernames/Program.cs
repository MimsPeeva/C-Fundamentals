internal class Program
{
    private static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine().Split(", ");
        foreach (string item in usernames)
        {
            if (item.Length < 3 || item.Length > 16)
            {
                continue;
            }

            if (ValidUsername(item))
            {
                Console.WriteLine(item);
            }

        }

    }
    private static bool ValidUsername(string username)
    {
        return username.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_');
    }
}