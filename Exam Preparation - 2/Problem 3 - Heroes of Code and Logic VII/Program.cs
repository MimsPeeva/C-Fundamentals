/*
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End

4
Adela 90 150
SirMullich 70 40
Ivor 1 111
Tyris 94 61
Heal - SirMullich - 50
Recharge - Adela - 100
CastSpell - Tyris - 1000 - Fireball
TakeDamage - Tyris - 99 - Fireball
TakeDamage - Ivor - 3 - Mosquito
End
 */

using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
        static List<Hero> heroList = new List<Hero>();
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());



        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            int hitPoints = int.Parse(input[1]);
            int manaPoints = int.Parse(input[2]);
            Hero hero = new Hero(name, hitPoints, manaPoints);
            heroList.Add(hero);
        }
        string lines;
        while ((lines = Console.ReadLine()) != "End")
        {
            string[] tokens = lines.Split(" - ");
            string command = tokens[0];
            string heroName = tokens[1];
            if (command == "CastSpell")
            {
                int MPNeeded = int.Parse(tokens[2]);
                string spellName = tokens[3];
                CastSpell(heroName, MPNeeded, spellName);
            }
            else if (command == "TakeDamage")
            {
                int damage = int.Parse(tokens[2]);
                string attacker = tokens[3];
                TakeDamage(heroName, damage, attacker);
            }
            else if (command == "Recharge")
            {
                int amount = int.Parse(tokens[2]);
                Recharge(heroName, amount);

            }
            else if (command == "Heal")
            {
                int amount = int.Parse(tokens[2]);
                Heal(heroName, amount);
            }
            static void CastSpell(string heroName, int MPNeeded, string spellName)
            {
                Hero foundHero = heroList.FirstOrDefault(hero => hero.Name == heroName);
                if (foundHero == null)
                { return; }
                else
                {
                    if (foundHero.ManaPoints >= MPNeeded)
                    {
                        foundHero.ManaPoints -= MPNeeded;
                        Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.ManaPoints} MP!");
                    }
                    else
                    { Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!"); }
                }
            }
            static void TakeDamage(string heroName, int damage, string attacker)
            {
                Hero foundHero = heroList.FirstOrDefault(h => h.Name == heroName);
                if (foundHero == null)
                { return; }
                else
                {
                    foundHero.HitPoints -= damage;
                    if (foundHero.HitPoints > 0)
                    { Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attacker} and now has {foundHero.HitPoints} HP left!"); }
                    else
                    {
                        heroList.Remove(foundHero);
                        Console.WriteLine($"{foundHero.Name} has been killed by {attacker}!");
                    }
                }
            }
            static void Recharge(string heroName, int amount)
            {
                Hero foundHero = heroList.FirstOrDefault(h => h.Name == heroName);
                if (foundHero == null)
                { return; }
                int recovered = foundHero.Recharge(amount);
                    Console.WriteLine($"{foundHero.Name} recharged for {recovered} MP!");
                
            }
            static void Heal(string heroName, int amount)
            {
                    Hero foundHero = heroList.FirstOrDefault(hero => hero.Name == heroName);
                if (foundHero == null)
                { return; }
                int recovered = foundHero.Heal(amount);
                Console.WriteLine($"{foundHero.Name} healed for {recovered} HP!");
                
            }
        }
        heroList.ForEach(h => Console.WriteLine(h));
    
    }

}

public class Hero
{
    public string Name { get; set; }
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }

    public Hero(string name, int hitPoints, int manaPoints)
    {
        Name = name;
        HitPoints = hitPoints;
        ManaPoints = manaPoints;
    }
    public int Recharge(int amount)
    {
        int recoveredMP = Math.Min(amount, 200 - ManaPoints);
        ManaPoints += recoveredMP;
        return recoveredMP;
    }
    public int Heal(int amount)
    {
        int recoveredMP = Math.Min(amount, 100 - HitPoints);
        HitPoints += recoveredMP;
        return recoveredMP;
    }
    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        str.AppendLine(Name);
        str.AppendLine($"  HP: {HitPoints}");
        str.Append($"  MP: {ManaPoints}");
        return str.ToString();
    }
}