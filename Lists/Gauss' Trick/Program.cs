List<double> numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();
List<double> result = new List<double>();
    for (int i = 0; i < numbers.Count/2; i++)
    {
        double first = numbers[i];
        double last = numbers[numbers.Count-i-1];
        result.Add(first+last);
    }
if (numbers.Count % 2 == 1)
{ double middleElement = numbers[numbers.Count/2]; 
    result.Add(middleElement);
}
Console.WriteLine(string.Join(" ", result));
