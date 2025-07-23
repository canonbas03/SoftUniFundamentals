namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            string noRepeat = string.Empty;
            char lastChar = default;
            for (int i = 0; i < word.Length; i++)
            {
                char character = word[i];
                if (character != lastChar)
                {
                    noRepeat += character;
                }
                lastChar = character;
            }
            Console.WriteLine(noRepeat);
        }
    }
}
