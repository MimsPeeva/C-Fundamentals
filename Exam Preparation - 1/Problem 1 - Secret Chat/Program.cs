string concealedMessage = Console.ReadLine();
string input;
while ((input = Console.ReadLine()) != "Reveal")
{
    string[] lines = input.Split(":|:");
    string command = lines[0];
    if (command == "InsertSpace")
    {
        int index = int.Parse(lines[1]);
        concealedMessage = concealedMessage.Insert(index, " ");
        Console.WriteLine(concealedMessage);

    }
    else if (command == "Reverse")
    {
        string substring = lines[1];
            int index = concealedMessage.IndexOf(substring);
            if (index <= -1)
        {    
            Console.WriteLine("error");

            continue;
            }
            concealedMessage = concealedMessage.Remove(index, substring.Length);
            string reverse = new string(substring.Reverse().ToArray());

            concealedMessage += reverse;
            Console.WriteLine(concealedMessage);
        

    }
    else if (command == "ChangeAll")
    {
        string substring = lines[1];
        string replacement = lines[2];
        concealedMessage = concealedMessage.Replace(substring, replacement);
        Console.WriteLine(concealedMessage);
    }
}
Console.WriteLine($"You have a new text message: {concealedMessage}");
/*
heVVodar!gniV
ChangeAll:|:V:|:l
Reverse:|:!gnil
InsertSpace:|:5
Reveal
*/