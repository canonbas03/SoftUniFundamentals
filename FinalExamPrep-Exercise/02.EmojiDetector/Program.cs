using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digitsPattern = @"\d";

            ulong coolTreshold = 1;
            foreach (Match match in Regex.Matches(input, digitsPattern))
            {
                coolTreshold *= ulong.Parse(match.Value);
            }

            string emojiPattern = @"(\:\:|\*\*)(?<Emoji>[A-Z][a-z]{2,})\1";
            int counter = 0;
            List<string> coolEmojis = new();
            foreach (Match match in Regex.Matches(input, emojiPattern))
            {
                counter++;

                string emoji = match.Groups["Emoji"].Value;
                ulong coolness = 0;
                foreach(char ch in emoji)
                {
                    coolness += ch;
                }
                if(coolness >= coolTreshold)
                {
                    coolEmojis.Add(match.Value);
                }

            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{counter} emojis found in the text. The cool ones are:");
            foreach(string emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}

/*
 In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**
 */
