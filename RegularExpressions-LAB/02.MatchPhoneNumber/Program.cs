using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    /*+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[ ]?\+359([ -])2\1[\d]{3}\1[\d]{4}\b";
            string phones = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollecton = regex.Matches(phones);

            List<string> trimmedMatches = new();
            foreach (Match match in matchCollecton)
            {
                trimmedMatches.Add(match.Value.Trim());
            }
            Console.WriteLine(string.Join(", ", trimmedMatches));
        }
    }
}
