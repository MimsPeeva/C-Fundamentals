using System.Numerics;

List<string> list = Console.ReadLine()
    .Split()
    .ToList();
string input;
int count = 0;
while ((input=Console.ReadLine()) != "end")
{
    int[] indexes = input.Split()
        .Select(int.Parse)
        .ToArray();
    int firstN = indexes[0];
    int secondN = indexes[1];
    count++;
    if (firstN == secondN ||
          (firstN < 0 || firstN >= list.Count)
          || (secondN < 0 || secondN >= list.Count))
    {
        string add = $"-{count}a";
        List<string> newElements = new List<string> { add, add };
        int middleIndex = list.Count / 2;
        list.InsertRange(middleIndex,newElements);
        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
   else
    { 
     if (list[firstN] == list[secondN])
        {
            string element = list[firstN];
            Console.WriteLine($"Congrats! You have found matching elements - {element}!");
            if (firstN < secondN)
            {
                list.RemoveAt(firstN); 
                list.RemoveAt(secondN-1);
            }
            else if(secondN<firstN)
            {
                list.RemoveAt(secondN);
                list.RemoveAt(firstN - 1);
            }
        }
        else
        { Console.WriteLine("Try again!"); }
    }
    if (list.Count == 0) 
    { 
        Console.WriteLine($"You have won in {count} turns!");
        break;
    }
}
if (list.Count != 0)
{
    Console.WriteLine("Sorry you lose :(");
    Console.WriteLine(string.Join(" ", list));
}