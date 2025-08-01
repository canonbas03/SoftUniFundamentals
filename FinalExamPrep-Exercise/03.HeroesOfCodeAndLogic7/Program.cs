


namespace _03.HeroesOfCodeAndLogic7
{
    internal class Program
    {
        public static Dictionary<string, Hero> heroes { get; set; }
        static void Main(string[] args)
        {
            heroes = new();
            uint count = uint.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] heroInput = Console.ReadLine().Split().ToArray();
                string heroName = heroInput[0];
                int hitPoints = int.Parse(heroInput[1]);
                int manaPoints = int.Parse(heroInput[2]);

                Hero hero = new Hero(heroName, hitPoints, manaPoints);
                heroes[heroName] = hero;
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" - ").ToArray();
                string action = arguments[0];
                switch (action)
                {
                    case "CastSpell":
                        string heroName = arguments[1];
                        int mpNeeded = int.Parse(arguments[2]);
                        string spellName = arguments[3];
                        CastSpell(heroName, mpNeeded, spellName);
                        break;

                    case "TakeDamage":
                        heroName = arguments[1];
                        int damage = int.Parse(arguments[2]);
                        string attacker = arguments[3];
                        TakeDamage(heroName, damage, attacker);
                        break;

                    case "Recharge":
                        heroName = arguments[1];
                        int amount = int.Parse(arguments[2]);
                        Recharge(heroName, amount);
                        break;

                    case "Heal":
                        heroName = arguments[1];
                        amount = int.Parse(arguments[2]);
                        Heal(heroName, amount);
                        break;
                }
            }
            foreach (Hero hero in heroes.Values)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }

        }

        public static void Heal(string heroName, int amount)
        {
            int pointsBefore = heroes[heroName].HitPoints;
            heroes[heroName].HitPoints += amount;
            heroes[heroName].HitPoints = Math.Min(100, heroes[heroName].HitPoints);
            Console.WriteLine($"{heroName} healed for {Math.Min(100 - pointsBefore, amount)} HP!");
        }

        public static void Recharge(string heroName, int amount)
        {
            int pointsBefore = heroes[heroName].ManaPoints;
            heroes[heroName].ManaPoints += amount;
            heroes[heroName].ManaPoints = Math.Min(200, heroes[heroName].ManaPoints);
            Console.WriteLine($"{heroName} recharged for {Math.Min(200 - pointsBefore, amount)} MP!");
        }

        public static void TakeDamage(string heroName, int damage, string attacker)
        {
            heroes[heroName].HitPoints -= damage;
            if (heroes[heroName].HitPoints > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
            }
            else
            {
                heroes.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
        }

        public static void CastSpell(string heroName, int mpNeeded, string spellName)
        {
            if (heroes[heroName].ManaPoints >= mpNeeded)
            {
                heroes[heroName].ManaPoints -= mpNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HitPoints = hp;
            ManaPoints = mp;
        }
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
/*
1
Adela 90 150
Recharge - Adela - 100
End
 */