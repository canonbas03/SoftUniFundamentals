namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string censor = new string('*', word.Length);
                text = text.Replace(word, censor);
            }
            Console.WriteLine(text);
        }
    }
}
