
namespace _03.CharsInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char first = char.Parse(Console.ReadLine());
           char second = char.Parse(Console.ReadLine());
            Console.WriteLine(CharsBetween(first, second));
        }

        private static string CharsBetween(char first, char second)
        {
            char firstChar = first, secondChar = second;
            if(second < first)
            {
                firstChar = second;
                secondChar = first;
            }

            string result = string.Empty;
            for(int i = firstChar+1; i < secondChar; i++) 
            {
                result += (char)i + " ";
            }
            return result;
        }
    }
}
