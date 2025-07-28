using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
            string[] participantNames = Console.ReadLine().Split(", ");
            for (int i = 0; i < participantNames.Length; i++)
            {
                string name = participantNames[i];
                participants.Add(name, new Participant(name));
            }

            string input = string.Empty;

            string patternDigits = @"\d";
            string patternLetters = @"[A-Za-z]";
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder name = new StringBuilder();
                foreach (Match match in Regex.Matches(input, patternLetters))
                {
                    name.Append(match.Value);
                }

                if(participants.ContainsKey(name.ToString()))
                {
                    int distance = 0;
                    foreach(Match match in Regex.Matches(input,patternDigits))
                    {
                        distance += int.Parse(match.Value);
                    }

                    participants[name.ToString()].Distance += distance;
                }
            }

            List<Participant> orderedParticipants = participants.Values.OrderByDescending(p => p.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {orderedParticipants[0].Name}");
            Console.WriteLine($"2nd place: {orderedParticipants[1].Name}");
            Console.WriteLine($"3rd place: {orderedParticipants[2].Name}");
        }
    }

    class Participant
    {
        public string Name { get; set; }
        public int Distance { get; set; }

        public Participant(string name)
        {
            Name = name;
            Distance = 0;
        }
    }
}
