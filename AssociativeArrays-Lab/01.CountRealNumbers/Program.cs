namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> numbersCount = new();

            foreach (int number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount[number] = 0;
                }
                numbersCount[number]++;
            }

            foreach((int key, int occurence) in numbersCount)
            {
                Console.WriteLine($"{key} -> {occurence}");
            }
        }
    }
}
