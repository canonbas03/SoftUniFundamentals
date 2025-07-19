namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToDelete = Console.ReadLine();
            string text = Console.ReadLine();

            while(text.Contains(wordToDelete))
            {
                int wordIndex = text.IndexOf(wordToDelete);
                text = text.Remove(wordIndex, wordToDelete.Length);
            }
            Console.WriteLine(text);
        }
    }
}
