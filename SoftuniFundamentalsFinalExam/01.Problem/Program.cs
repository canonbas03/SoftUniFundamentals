




namespace _01.Problem
{
    internal class Program
    {
        public static string Spell { get; set; }
        static void Main(string[] args)
        {
            Spell = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                switch (command)
                {
                    case "Abjuration":
                        Abjuration();
                        break;
                    case "Necromancy":
                        Necromancy();
                        break;
                    case "Illusion":
                        int index = int.Parse(arguments[1]);
                        char letter = char.Parse(arguments[2]);
                        Illusion(index, letter);
                        break;
                    case "Divination":
                        string oldSubstring = arguments[1];
                        string newSubstring = arguments[2];
                        Divination(oldSubstring, newSubstring);
                        break;
                    case "Alteration":
                        string substring = arguments[1];
                        Alteration(substring);
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }

        private static void Alteration(string substring)
        {
            if (Spell.Contains(substring))
            {
                int index = Spell.IndexOf(substring);
                Spell = Spell.Remove(index, substring.Length);
                Console.WriteLine(Spell);
            }
        }

        private static void Abjuration()
        {
            Spell = Spell.ToUpper();
            Console.WriteLine(Spell);
        }
        private static void Necromancy()
        {
            Spell = Spell.ToLower();
            Console.WriteLine(Spell);
        }
        private static void Illusion(int index, char letter)
        {
            if (index < Spell.Length)
            {
                char[] letters = Spell.ToCharArray();
                letters[index] = letter;
                Spell = new string(letters);
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("The spell was too weak.");
            }
        }
        private static void Divination(string oldSubstring, string newSubstring)
        {
            if (Spell.Contains(oldSubstring))
            {
                Spell = Spell.Replace(oldSubstring, newSubstring);
                Console.WriteLine(Spell);
            }
        }
    }
}
