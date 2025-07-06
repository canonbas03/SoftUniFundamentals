namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int minIndex = (list1.Count <= list2.Count) ? list1.Count : list2.Count;

            List<int> mergedList = new List<int>();
            for (int i = 0; i < minIndex; i++)
            {
                mergedList.Add(list1[i]);
                mergedList.Add(list2[i]);
            }

            //Console.WriteLine(string.Join(" ", mergedList));

            if (list1.Count > list2.Count)
            {
                for (int i = list2.Count; i < list1.Count; i++)
                {
                    mergedList.Add(list1[i]);
                }
            }
            else if (list2.Count > list1.Count)
            {
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    mergedList.Add(list2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
