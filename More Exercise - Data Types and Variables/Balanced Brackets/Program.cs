using System;

namespace Balanced_Brackets
{
    internal class Program
    {
    static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClose = 0;
            for (int i = 1; i <=numberOfLines; i++)
            {
                string symbol = Console.ReadLine();
                if (symbol == "(")
                {
                    countOpen++;
                   
                }
                if (symbol == ")")
                {
                    countClose++;
                    if (countOpen - countClose != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
           

        }
        if (countClose == countOpen) 
            { Console.WriteLine("BALANCED"); }
            else
            { Console.WriteLine("UNBALANCED"); }
        }
    }
}
