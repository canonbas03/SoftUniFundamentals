using System.Text.RegularExpressions;

namespace _02.MessageDecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1\: \[(?<ascii1>[0-9]+)\]\|\[(?<ascii2>[0-9]+)\]\|\[(?<ascii3>[0-9]+)\]\|$";
            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    
                        int ascii = int.Parse(match.Groups["ascii1"].Value);
                        char first = (char)ascii;
                        ascii = int.Parse(match.Groups["ascii2"].Value);
                        char second = (char)ascii;
                        ascii = int.Parse(match.Groups["ascii3"].Value);
                        char third = (char)ascii;
                        Console.WriteLine($"{match.Groups["tag"].Value}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}


/*
4
$Request$: [73]|[115]|[105]|
%Taggy$: [73]|[73]|[73]|
%Taggy%: [118]|[97]|[108]|
$Request$: [73]|[115]|[105]|[32]|[75]|

 */