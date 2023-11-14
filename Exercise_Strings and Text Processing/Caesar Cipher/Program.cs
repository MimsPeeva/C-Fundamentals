using System.Text;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
            {
            int symbol = input[i] + 3;
                result.Append((char)symbol);
            }
            Console.WriteLine(result);
        }
    }
}