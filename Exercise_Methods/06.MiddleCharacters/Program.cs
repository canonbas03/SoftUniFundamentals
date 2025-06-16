
namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            ShowMiddle(text);
        }

        private static void ShowMiddle(string? text)
        {
            int middle = (text.Length / 2) - 1;
            if(text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[middle]}{text[middle + 1]}");
            }
            else
            {
                Console.WriteLine(text[middle+1]);
            }
        }
    }
}
