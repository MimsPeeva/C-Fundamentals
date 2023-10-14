List<int> integers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
string input = default;
bool isTrue = false;
while ((input = Console.ReadLine()) != "end")
{
    string[] lineTokens = input.Split(' ').ToArray();
    string command = lineTokens[0];
    switch (command)
    {
        case "Add":
            int number = int.Parse(lineTokens[1]);
            integers.Add(number);isTrue = true; break;
        case "Remove":
            int number1 = int.Parse(lineTokens[1]);
            integers.Remove(number1); isTrue = true; break;
        case "RemoveAt":
            int number2 = int.Parse(lineTokens[1]);
            integers.RemoveAt(number2); isTrue = true; break;
        case "Insert":
            int number3 = int.Parse(lineTokens[1]);
            int indexToInsert = int.Parse(lineTokens[2]);
            integers.Insert(indexToInsert, number3); isTrue = true; break;
        case "Contains":
            int number4 = int.Parse(lineTokens[1]);
            if (integers.Contains(number4)) { Console.WriteLine("Yes"); }
            else
            { Console.WriteLine("No such number"); }
            break;
        case "PrintEven":

            List<int> even = new List<int>();
            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    even.Add(integers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", even));
            break;
        case "PrintOdd":
            List<int> odd = new List<int>();
            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 != 0 )
                {
                    odd.Add(integers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", odd));
            break;
        case "GetSum":
            int sum = 0;
            for (int i = 0; i < integers.Count; i++)
            {
                sum += integers[i];
            }
             Console.WriteLine(sum); break;
        case "Filter":
            //int number8 = int.Parse(lineTokens[1]);
            string conditional = lineTokens[1];
          int numConditional = int.Parse(lineTokens[2]);
           if (conditional==">") 
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] > numConditional)
                    {
                        numbers.Add(integers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if (conditional == "<")
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] < numConditional)
                    {
                        numbers.Add(integers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if (conditional == "<=")
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] <= numConditional)
                    {
                        numbers.Add(integers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            else if (conditional == ">=")
            {
                List<int> numbers = new List<int>();
                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] >= numConditional)
                    {
                        numbers.Add(integers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", numbers));

            }
            break;
    }
}
if (isTrue) Console.WriteLine(string.Join(" ",integers));

