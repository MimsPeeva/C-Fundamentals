using System.Text;
using System.Text.RegularExpressions;



internal class Program
{
    static void Main()
    {

        List<Message> messages = new List<Message>();

        int messagesCount = int.Parse(Console.ReadLine());

        string starPattern = @"[SsTtAaRr]";
        string msgPattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*\:(?<population>\d+)[^\@\-\!\:\>]*\!(?<type>A|D)\![^\@\-\!\:\>]*\-\>[^\@\-\!\:\>]*?(?<soldiers>\d+)[^\@\-\!\:\>]*";

        for (int i = 0; i < messagesCount; i++)
        {
            string encryptMsg = Console.ReadLine();

            int decryptionKey = Regex.Matches(encryptMsg, starPattern).Count;

            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < encryptMsg.Length; j++)
            {
                sb.Append((char)(encryptMsg[j] - decryptionKey));
            }

            string encryptedMsg = sb.ToString();

            var match = Regex.Match(encryptedMsg, msgPattern);
            if (Regex.IsMatch(encryptedMsg, msgPattern) == false)
            {
                continue;
            }
            Message message = new Message();
            message.PlanetName = match.Groups["planet"].Value;
            message.Population = uint.Parse(match.Groups["population"].Value);
            message.AttackType = match.Groups["type"].Value;
            message.SoldierCount = uint.Parse(match.Groups["soldiers"].Value);


            messages.Add(message);
        }

        var planets = messages.Where(m => m.AttackType == "A")
            .OrderBy(m => m.PlanetName)
            .ToList();

        Console.WriteLine($"Attacked planets: {planets.Count}");
        planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

        planets = messages.Where(m => m.AttackType == "D")
            .OrderBy(m => m.PlanetName)
            .ToList();

        Console.WriteLine($"Destroyed planets: {planets.Count}");
        planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

    }
    class Message
    {

        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }


    }
}