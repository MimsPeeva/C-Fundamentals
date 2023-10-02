/*
5
1!0!1!1!0
0!1!1!0!0
Clone them!
 */
/*
4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!
 */
int dnaLength = int.Parse(Console.ReadLine());
string input = string.Empty;
int counter = 0;
int countOnes = 0;
//string[] arrToPrint = new string[dnaLength];
while ((input = Console.ReadLine()) != "Clone them!")
{
    counter++;
    int[] arr = input.Split('!').Select(int.Parse).ToArray();

    for (int i = 0; i < dnaLength ; i++)
    {
        if (arr[i]==1)
        {
           
            countOnes++;
            if (countOnes >= 0)
            {
                int mostOnes = countOnes;
               
            }
        }
        if (input == "Clone them!") 
        {
            Console.WriteLine($"Best DNA sample {counter} with sum: {countOnes}.");
            Console.WriteLine(string.Join(" ", arr)); 
        }
    } 
}
