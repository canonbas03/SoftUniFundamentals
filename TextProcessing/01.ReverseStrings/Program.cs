namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                words.Add(input);
            }

                string reversed = string.Empty;
            foreach (string word in words)
            {
                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                Console.WriteLine($"{word} = {reversed}");
                reversed = string.Empty;
            }
        }
    }
}
