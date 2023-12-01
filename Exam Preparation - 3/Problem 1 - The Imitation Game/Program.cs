using System.Text;

string encryptedMessage = Console.ReadLine();
string input;
while ((input=Console.ReadLine()) != "Decode")
{
    string[] lines = input.Split('|');
    string command = lines[0];
    switch (command)
    {
        case "Move":
            int lettersNumber = int.Parse(lines[1]);
            string firstPart = encryptedMessage.Substring(0,lettersNumber);
            string secondPart = encryptedMessage.Substring(lettersNumber);
            encryptedMessage = secondPart + firstPart;
            break;
        case "Insert":
            int index = int.Parse(lines[1]);
            string value = lines[2];
           encryptedMessage = encryptedMessage.Insert(index,value);
                break;
        case "ChangeAll":
            string substring = lines[1];
            string replacement = lines[2];
          encryptedMessage = encryptedMessage.Replace(substring,replacement);
            break;

    }
}
    Console.WriteLine($"The decrypted message is: {encryptedMessage}");
/*
zzHe
ChangeAll|z|l
Insert|2|o
Move|3
Decode
*/