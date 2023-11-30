string key = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Generate")
{
    string[] lines = input.Split(">>>");
    string command = lines[0];
    if (command == "Contains")
    {
        string substring = lines[1];
        if (key.Contains(substring))
        {
            Console.WriteLine($"{key} contains {substring}");
        }
        else
        { Console.WriteLine("Substring not found!"); }
    }
    else if (command == "Flip")
    {
        string type = lines[1];
        int startIndex = int.Parse(lines[2]);
        int endIndex = int.Parse(lines[3]);
        if (type == "Upper")
        {
        string prefix = key.Substring(0, startIndex);
            string middle = key.Substring(startIndex, endIndex - startIndex).ToUpper();
           string suffix = key.Substring(endIndex);
            key = prefix + middle + suffix;
            Console.WriteLine(key);
        }
        else if (type == "Lower")
        {
            string prefix = key.Substring(0, startIndex);
            string middle = key.Substring(startIndex, endIndex - startIndex).ToLower();
            string suffix = key.Substring(endIndex);
            key = prefix + middle + suffix;
            Console.WriteLine(key);
        }
    }
    else if (command == "Slice")
    {
        int startIndex = int.Parse(lines[1]);
        int endIndex = int.Parse(lines[2]);
        string prefix = key.Substring(0, startIndex);
        string middle = key.Substring(startIndex, endIndex - startIndex).ToUpper();
        string suffix = key.Substring(endIndex);
        key = prefix + suffix;
        Console.WriteLine(key);
    }
}
Console.WriteLine($"Your activation key is: {key}");
/*
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def
*/