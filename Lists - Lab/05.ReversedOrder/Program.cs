namespace _05.ReversedOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            if (list.Count > 0)
            {
                list.Reverse();
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");

            }

        }
    }
}
