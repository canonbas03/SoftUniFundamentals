namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charsCount = new();
            char[] chars = Console.ReadLine().ToCharArray();

            foreach (char c in chars)
            {
                if (c != ' ')
                {
                    if (!charsCount.ContainsKey(c))
                    {
                        charsCount[c] = 0;
                    }
                    charsCount[c]++;
                }
            }
            foreach ((char letter, int count) in charsCount)
            {
                Console.WriteLine($"{letter} -> {count}");
            }
        }
    }
}
