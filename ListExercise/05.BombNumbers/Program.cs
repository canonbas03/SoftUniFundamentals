namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = bomb[0];
            int power = bomb[1];

            while(list.Contains(number))
            {
                int bombIndex = list.IndexOf(number);

                int leftIndex = Math.Max(0, bombIndex - power);
                int rightIndex = Math.Min(list.Count-1, bombIndex + power);

                int rangeToRemove = rightIndex - leftIndex + 1;
                list.RemoveRange(leftIndex, rangeToRemove);
            }
            Console.WriteLine(list.Sum());
        }
    }
}
