namespace _02.OddOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> inputCounts = new Dictionary<string, int>();

            foreach (string input in inputs)
            {
                if (!inputCounts.ContainsKey(input))
                {
                    inputCounts[input] = 0;
                }
                inputCounts[input]++;
            }

            foreach((string word, int count) in inputCounts)
            {
                if(count % 2 != 0)
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
