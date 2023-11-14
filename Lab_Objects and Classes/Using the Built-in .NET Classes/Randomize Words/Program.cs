string[] arr = Console.ReadLine()
    .Split()
    .ToArray();
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    int randomIndex = rnd.Next(arr.Length);
    string currentWord = arr[i];
    string randomWord = arr[randomIndex];
    arr[i] = randomWord;
    arr[randomIndex] = currentWord;
}
foreach (string item in arr)
{
    Console.WriteLine(item);

}