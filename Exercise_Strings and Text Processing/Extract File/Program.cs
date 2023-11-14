string input = Console.ReadLine();
string name = string.Empty;
string extension = string.Empty;
int indexOfLastSeparator = input.LastIndexOf('\\');
int extensionIndex = input.LastIndexOf('.');
if (indexOfLastSeparator !=-1 && extensionIndex!=-1 && extensionIndex>indexOfLastSeparator)
{
    name = input.Substring(indexOfLastSeparator + 1, extensionIndex - indexOfLastSeparator  - 1);
    extension = input.Substring(extensionIndex+1);
}
Console.WriteLine($"File name: {name}");
Console.WriteLine($"File extension: {extension}");