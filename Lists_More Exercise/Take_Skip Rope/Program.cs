string message = Console.ReadLine();
List<int> numbers = new List<int>();
List<string> nonNumbers = new List<string>();
List<int> skipList = new List<int>();
List <int> takeList = new List<int>();
for (int i = 0; i < message.Length; i++)
{
    if (char.IsDigit(message[i]))
    {
        numbers.Add(int.Parse(message[i].ToString()));
    }
    else
    {
        nonNumbers.Add(message[i].ToString());
    }
}
for (int i = 0; i < numbers.Count; i++)
{
    if (i % 2 == 0)
    {
        takeList.Add(numbers[i]);
    }
    else 
    {
        skipList.Add(numbers[i]);
    }
}
string result = "";
int index = 0;
for (int i = 0; i < takeList.Count; i++)
{
    int takeIndex = takeList[i];
    int skipIndex = skipList[i];
    if (takeIndex + index > nonNumbers.Count)
    {
        takeIndex = nonNumbers.Count - index;
    }
    for (int j = 0; j < takeIndex; j++)
    {
        result += nonNumbers[index+j];
    }
    index += takeIndex + skipIndex;
}
Console.WriteLine(result);
