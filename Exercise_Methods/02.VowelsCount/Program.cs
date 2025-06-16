
namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(VowelsCount(word));
        }

        private static string VowelsCount(string? word)
        {
            int counter = default;
            foreach (char symbol in word)
            {
                if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' ||
                    symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U')
                {
                    counter++;
                }
            }
            return counter.ToString(); 
        }
    }
}
