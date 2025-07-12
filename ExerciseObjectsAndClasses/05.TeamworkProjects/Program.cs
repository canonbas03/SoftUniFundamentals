using System.Security.Cryptography;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string[] teamArguments = Console.ReadLine().Split("-");
                string creatorName = teamArguments[0];
                string teamName = teamArguments[1];

                Team foundTeamWithSameName = teams.Find(t => t.Name == teamName);
                if (foundTeamWithSameName != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                Team foundTeamCreator = teams.Find(t => t.Creator == creatorName);
                if (foundTeamCreator != null)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] arguments = input.Split("->");
                string joiner = arguments[0];
                string teamName = arguments[1];

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Creator == joiner) || teams.Any(t => t.Members.Contains(joiner)))
                {
                    Console.WriteLine($"Member {joiner} cannot join team {teamName}!");
                    continue;
                }

                Team foundTeam = teams.Find(t => t.Name == teamName);
                foundTeam.Members.Add(joiner);
            }

            List<Team> leftTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandedTeams = teams.Where(t => t.Members.Count == 0).ToList();

            List<Team> orderedTeams = leftTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();

            orderedTeams.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Teams to disband:");
            orderedTeams = disbandedTeams.OrderBy(d => d.Name).ToList();
            orderedTeams.ForEach(t => Console.WriteLine(t.Name));
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            string result = $"{Name}\n";
            result += $"- {Creator}\n";

            Members = Members.OrderBy(m => m).ToList();

            int i = 0;
            for (; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }
            result += $"-- {Members[i]}";

            return result;
        }
    }
}
