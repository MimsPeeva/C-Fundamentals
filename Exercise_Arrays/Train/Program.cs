int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    arr[i] = number;
    sum += number;
   
}
Console.Write(String.Join(" ", arr));
Console.WriteLine();
Console.WriteLine(sum);