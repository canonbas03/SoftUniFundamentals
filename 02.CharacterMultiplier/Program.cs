
namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string firstWord = words[0];
            string secondWord = words[1];

            Console.WriteLine(Sum(firstWord, secondWord));
        }

        public static int Sum(string firstWord, string secondWord)
        {
            int result = default;
            int maxLength = Math.Max(firstWord.Length, secondWord.Length);
            for (int index = 0; index < maxLength; index++)
            {
                if(index < firstWord.Length && index < secondWord.Length)
                {
                    result += firstWord[index] * secondWord[index];
                }
                else if(index < firstWord.Length)
                {
                    result += firstWord[index];
                }
                else if(index < secondWord.Length)
                {
                    result += secondWord[index];
                }
            }

            return result;
        }
    }
}
