string first = Console.ReadLine();
string second = Console.ReadLine();
    int indexOf = second.IndexOf(first);
while(indexOf!=-1)
{
    second = second.Remove(indexOf, first.Length);
    indexOf = second.IndexOf(first);
}
Console.WriteLine(second);