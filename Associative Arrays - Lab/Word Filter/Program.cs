List<string> words = Console.ReadLine()
    .Split()
    .Where(x => x.Length%2==0)
    .ToList();
foreach (var item in words)
{
    Console.WriteLine(item);
}
//Second variant
//Console.ReadLine()
//    .Split()
//    .Where(x => x.Length % 2 == 0)
//    .ToList()
//    .ForEach(Console.WriteLine);