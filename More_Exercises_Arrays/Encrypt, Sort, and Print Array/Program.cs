/*
4
Peter
Maria
Katya
Todor
 */
using System.Collections;

int n = int.Parse(Console.ReadLine());
int sum = 0;
int[] sumArr = new int[n];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    char[] index = input.ToCharArray();
    for (int j = 0; j < index.Length; j++)
    {
        if (index[j] == 'a' || index[j] == 'e' || input[j] == 'i' || index[j] == 'o' || index[j] == 'u' || index[j] == 'u'
          || index[j] == 'A' || index[j] == 'E' || input[j] == 'I' || index[j] == 'O' || index[j] == 'U' || index[j] == 'U')

        {
            sum += index[j] * index.Length;
        }
        else
        {
            sum += index[j] / index.Length;
        }
       
    }
    sumArr[i] = sum;
    sum = 0;
}
Array.Sort(sumArr);
for (int k = 0; k < sumArr.Length; k++)
{
    Console.WriteLine(sumArr[k]);
}


