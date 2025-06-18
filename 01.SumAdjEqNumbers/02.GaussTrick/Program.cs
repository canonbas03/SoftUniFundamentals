namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int halfIndex = numbers.Count / 2;

            for (int i = 0; i < halfIndex; i++)
            {
                numbers[i] += numbers[numbers.Count-1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
