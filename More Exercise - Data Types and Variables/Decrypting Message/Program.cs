using System;

namespace Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 1; i <=numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int l = (int)(letter + key);
                char symbol = (char)l;
                word += symbol;
            }
            Console.Write(word);
        }
    }
}
